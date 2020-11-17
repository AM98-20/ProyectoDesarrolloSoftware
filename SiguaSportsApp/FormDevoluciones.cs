using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiguaSportsApp
{
    public partial class FormDevoluciones : Form
    {
        public FormDevoluciones()
        {
            InitializeComponent();
        }

        ClassDatosTablas conexion = new ClassDatosTablas();
        string query = "SELECT B.nombre[Producto] , A.cantidad[Cantidad] , A.motivo[Motivo] ,C.fecha_devolucion[Fecha de Devolución], A.cod_producto_cambio [Producto Cambio]" +
                                         "FROM DevolucionDetalle A " +
                                         "INNER JOIN Productos B ON A.cod_producto = B.cod_producto " +
                                         "INNER JOIN Devoluciones C ON A.num_devolucion = C.num_devolucion";
        private void FromDevoluciones_Load(object sender, EventArgs e)
        {
            conexion.CargarDatosTablas(dgvHistorial, query);
            txtDevolucion.Text = conexion.DevolucionCodigo();
            txtvendedor.Text = conexion.Nombre_empleado;
            btn_Buscar.Visible = true;
            btn_Agregar.Visible = false;
            tran.Subtotal = 0.00;
            tran.Descuento = 0.00;
            tran.Impuesto = 0.00;
            tran.TotalDevolucion = 0.00;
        }

        ClassValidacion validacion = new ClassValidacion();
        ClassDatosTransaccion tran = new ClassDatosTransaccion();

        bool letra1 = false;
        bool letra2 = false;

        public void validar()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtCodProd))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtCodProd))
                    ErrorProvider.SetError(txtCodProd, "No se puede dejar en blanco");
            }
            else
            {
                letra1 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtMotivo) || validacion.Solo_Letras(ErrorProvider, txtMotivo))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtMotivo))
                    ErrorProvider.SetError(txtMotivo, "No se puede dejar en blanco");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtMotivo))
                    ErrorProvider.SetError(txtMotivo, "Solo se permite letras");
            }
            else
            {
                letra2 = true;
            }
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentas ven = new FormVentas();
            ven.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SideBar.Width == 204)
            {
                SideBar.Visible = false;
                SideBar.Width = 52;
                contenedor_menu.Width = 82;
                linea_sidebar.Width = 48;
                contraer_menu.Show(SideBar);
            }
            else
            {
                SideBar.Visible = false;
                SideBar.Width = 204;
                contenedor_menu.Width = 222;
                linea_sidebar.Width = 198;
                expandir_menu.Show(SideBar);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string Mensaje = conexion.BuscarDev(mtb_Factura.Text.ToString());
            int Dias = 0;

            if (Mensaje == "Existe")
            {
                try
                {
                    conexion.cmd = new SqlCommand("select DATEDIFF(DAY, fecha_Venta, GETDATE()) Dias " +
                        "from Ventas where num_factura = '" + mtb_Factura.Text.ToString() + "'", conexion.sc);
                    conexion.AbrirConexion();
                    SqlDataReader read = conexion.cmd.ExecuteReader();
                    if (read.Read())
                    {
                        Dias = int.Parse(read["Dias"].ToString());
                    }
                    conexion.CerrarConexion();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR " + ex);
                }

                if (Dias > 3)
                {
                    txtCodProd.ReadOnly = false;
                    txtMotivo.ReadOnly = false;
                    txtCantidad.ReadOnly = false;
                    btn_Buscar.Visible = false;
                    btn_Agregar.Visible = true;
                    mtb_Factura.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("La fecha de venta excedio la fecha limite de devolucion.", "Limite excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Error, no se encontro la factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            validar();
            if (letra1 && letra2)
            {
                letra2 = false; letra1 = false;
                try
                {
                    conexion.cmd = new SqlCommand("if exists(Select cod_prducto from VentaDetalle " +
                        "where num_factura = '"+mtb_Factura.Text.ToString()+"' and cod_prducto = '"+txtCodProd.Text.ToString()+"') " +
                        "begin select CONCAT(p.nombre, ' ', p.color, ' ', p.marca) Descripcion, cod_prducto, precioVenta, cantidad, " +
                        "descuentoPorcentaje, impuestoPorcentaje from VentaDetalle vd inner join Ventas v " +
                        "on vd.num_factura = v.num_factura where vd.num_factura = '"+mtb_Factura.Text.ToString()+ "' and cod_prducto = '" + txtCodProd.Text.ToString() + "' end", conexion.sc);
                    conexion.AbrirConexion();
                    SqlDataReader lector = conexion.cmd.ExecuteReader();
                    if (lector.Read())
                    {
                        string[] row =  new string[] { lector["cod_producto"].ToString(), lector["Descripcion"].ToString(), 
                            lector["precioVenta"].ToString(), txtCantidad.Text.ToString(), txtMotivo.Text.ToString()};
                        dgvDevoluciones.Rows.Add(row);
                        tran.PorcentajeDes = double.Parse(lector["descuentoPorcentaje"].ToString());
                        tran.PorcentajeImp = double.Parse(lector["impuestoPorcentaje"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el producto en la venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conexion.CerrarConexion();

                    foreach (DataGridViewRow row in dgvDevoluciones.Rows)
                    {
                        tran.Subtotal += (double)row.Cells["Precio"].Value * (double)row.Cells["Cantidad"].Value;                        
                    }
                    tran.CalculoDescuento();
                    tran.CalculoImpuesto();
                    tran.CalculoTotal();
                    txttotal.Text = tran.TotalDevolucion.ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR "+ex);
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvDevoluciones.Rows.Count == 0)
                MessageBox.Show("No hay datos seleccionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tran.CodConf = 1;
                FormConfirmacion conf = new FormConfirmacion();
                conf.ShowDialog();

                if (tran.CodConf == 2)
                {
                    conexion.cmd = new SqlCommand("INSERT INTO Devoluciones(num_devolucion, num_factura, fecha_devolucion, " +
                        "cod_empleado) values('" + txtDevolucion.Text.ToString() + "','" + mtb_Factura.Text.ToString() + "'," +
                        "'" + dtp_Fecha.Value.ToShortDateString() + "','" + conexion.Cod_empleado + "')", conexion.sc);
                    conexion.AbrirConexion();
                    conexion.cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();

                    conexion.cmd = new SqlCommand("INSERT INTO DevolucionDetalle(num_devolucion, cod_producto, cantidad, motivo, cod_estado) " +
                        "values('" + txtDevolucion.Text.ToString() + "','@codProd','@cantidad','@motivo','1')", conexion.sc);
                    foreach (DataGridViewRow row in dgvDevoluciones.Rows)
                    {
                        conexion.cmd.Parameters.Clear();

                        conexion.cmd.Parameters.AddWithValue("@codProd", Convert.ToString(row.Cells["columna_producto"].Value));
                        conexion.cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["columna_catidad"].Value));
                        conexion.cmd.Parameters.AddWithValue("@motivo", Convert.ToString(row.Cells["columna_motivo"].Value));
                        conexion.AbrirConexion();
                        conexion.cmd.ExecuteNonQuery();
                        conexion.CerrarConexion();
                    }

                    DialogResult result = MessageBox.Show("Se ingresara devulta al inventario?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        conexion.cmd = new SqlCommand("UPDATE Productos set existencia = existencia + @cantidad where cod_producto = @codProd", conexion.sc);
                        foreach (DataGridViewRow row in dgvDevoluciones.Rows)
                        {
                            conexion.cmd.Parameters.Clear();

                            conexion.cmd.Parameters.AddWithValue("@codProd", Convert.ToString(row.Cells["columna_producto"].Value));
                            conexion.cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["columna_cantidad"].Value));
                            conexion.AbrirConexion();
                            conexion.cmd.ExecuteNonQuery();
                            conexion.CerrarConexion();
                        }
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo confirmar. Llame a su supervisor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boton_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentas ven = new FormVentas();
            ven.ShowDialog();
            this.Close();
        }

        private void btn_Cambio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCambio cam = new FormCambio();
            cam.ShowDialog();
            this.Close();
        }

        private void btn_Inventario_bodega_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventarioBodega inv = new FormInventarioBodega();
            inv.ShowDialog();
            this.Close();
        }

        private void btn_Registro_bodega_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistroBodega reg = new FormRegistroBodega();
            reg.ShowDialog();
            this.Close();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReportes rep = new FormReportes();
            rep.ShowDialog();
            this.Close();
        }

        private void btn_logueo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngreso ing = new FormIngreso();
            ing.ShowDialog();
            this.Close();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
