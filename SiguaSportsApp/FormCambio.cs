using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiguaSportsApp
{
    public partial class FormCambio : Form
    {
        public FormCambio()
        {
            InitializeComponent();            
        }

        private void FormCambio_Load(object sender, EventArgs e)
        {
            txtDevolucion.Text = con.DevolucionCodigo();
            txtvendedor.Text = con.Nombre_empleado;
            btn_Buscar.Visible = true;
            btn_Agregar.Visible = false;
            tran.Subtotal = 0.00;
            tran.Descuento = 0.00;
            tran.Impuesto = 0.00;
            tran.TotalDevolucion = 0.00;
        }

        ClassConexionBD con = new ClassConexionBD();
        ClassDatosTransaccion tran = new ClassDatosTransaccion();
        ClassValidacion validacion = new ClassValidacion();

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvCambio.Rows.Count == 0)
                MessageBox.Show("No hay datos seleccionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tran.CodConf = 1;
                FormConfirmacion conf = new FormConfirmacion();
                conf.ShowDialog();

                if (tran.CodConf == 2)
                {
                    con.cmd = new SqlCommand("INSERT INTO Devoluciones(num_devolucion, num_factura, fecha_devolucion, " +
                        "cod_empleado) values('" + txtDevolucion.Text.ToString() + "','" + mtb_Factura.Text.ToString() + "'," +
                        "'" + dtp_Fecha.Value.ToShortDateString() + "','" + con.Cod_empleado + "')", con.sc);
                    con.AbrirConexion();
                    con.cmd.ExecuteNonQuery();
                    con.CerrarConexion();

                    con.cmd = new SqlCommand("INSERT INTO DevolucionDetalle(num_devolucion, cod_producto, cantidad, motivo, cod_estado, cod_producto_cambio) " +
                        "values('" + txtDevolucion.Text.ToString() + "','@codProd','@cantidad','@motivo','2', '@codProd')", con.sc);
                    foreach (DataGridViewRow row in dgvCambio.Rows)
                    {
                        con.cmd.Parameters.Clear();

                        con.cmd.Parameters.AddWithValue("@codProd", Convert.ToString(row.Cells["columna_codigo"].Value));
                        con.cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["columna_cantidad"].Value));
                        con.cmd.Parameters.AddWithValue("@motivo", Convert.ToString(row.Cells["columna_codCambio"].Value));
                        con.AbrirConexion();
                        con.cmd.ExecuteNonQuery();
                        con.CerrarConexion();
                    }

                    DialogResult result = MessageBox.Show("Se ingresara devulta al inventario?", "Inventario", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if(result == DialogResult.Yes)
                    {
                        con.cmd = new SqlCommand("UPDATE Productos set existencia = existencia + @cantidad where cod_producto = @codProd", con.sc);
                        foreach (DataGridViewRow row in dgvCambio.Rows)
                        {
                            con.cmd.Parameters.Clear();

                            con.cmd.Parameters.AddWithValue("@codProd", Convert.ToString(row.Cells["columna_codigo"].Value));
                            con.cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["columna_cantidad"].Value));
                            con.AbrirConexion();
                            con.cmd.ExecuteNonQuery();
                            con.CerrarConexion();
                        }
                    }

                    this.Hide();
                    FormVentas ven = new FormVentas();
                    ven.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo confirmar. Llame a su supervisor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentas venta = new FormVentas();
            venta.ShowDialog();
            this.Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 204)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 52;
                contenedor_menu.Width = 82;
                LineaSidebar.Width = 48;
                contraer_menu.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 204;
                contenedor_menu.Width = 222;
                LineaSidebar.Width = 198;
                Expandir_menu.Show(Sidebar);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string Mensaje = con.BuscarDev(mtb_Factura.Text.ToString());
            int Dias = 0;

            if (Mensaje == "Existe")
            {
                try
                {
                    con.cmd = new SqlCommand("select DATEDIFF(DAY, fecha_Venta, GETDATE()) Dias " +
                        "from Ventas where num_factura = '" + mtb_Factura.Text.ToString() + "'", con.sc);
                    con.AbrirConexion();
                    SqlDataReader read = con.cmd.ExecuteReader();
                    if (read.Read())
                    {
                        Dias = int.Parse(read["Dias"].ToString());
                    }
                    con.CerrarConexion();
                }
                catch (Exception ex)
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
                    con.cmd = new SqlCommand("if exists(Select cod_prducto from VentaDetalle " +
                        "where num_factura = '" + mtb_Factura.Text.ToString() + "' and cod_prducto = '" + txtCodProd.Text.ToString() + "') " +
                        "begin select CONCAT(p.nombre, ' ', p.color, ' ', p.marca) Descripcion, cod_prducto, precioVenta, cantidad, " +
                        "descuentoPorcentaje, impuestoPorcentaje from VentaDetalle vd inner join Ventas v " +
                        "on vd.num_factura = v.num_factura where vd.num_factura = '"+mtb_Factura.Text.ToString()+ "' and cod_prducto = '" + txtCodProd.Text.ToString() + "' end", con.sc);
                    con.AbrirConexion();
                    SqlDataReader lector = con.cmd.ExecuteReader();
                    if (lector.Read())
                    {
                        string[] row = new string[] { lector["cod_producto"].ToString(), lector["Descripcion"].ToString(),
                            lector["precioVenta"].ToString(), txtCantidad.Text.ToString(), txtMotivo.Text.ToString(), lector["cod_producto"].ToString()};
                        dgvCambio.Rows.Add(row);
                        tran.PorcentajeDes = double.Parse(lector["descuentoPorcentaje"].ToString());
                        tran.PorcentajeImp = double.Parse(lector["impuestoPorcentaje"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el producto en la venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.CerrarConexion();

                    tran.Subtotal = 0.00;
                    tran.Descuento = 0.00;
                    tran.Impuesto = 0.00;
                    tran.TotalDevolucion = 0.00;
                    txtSub.Text = tran.Subtotal.ToString();
                    txtDes.Text = tran.Descuento.ToString();
                    txtISV.Text = tran.Impuesto.ToString();
                    txtTotal.Text = tran.TotalDevolucion.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex);
                }
            }
        }

        private void btn_maximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_restaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCambio cam = new FormCambio();
            cam.ShowDialog();
            this.Close();
        }

        private void btn_Devoluciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDevoluciones dev = new FormDevoluciones();
            dev.ShowDialog();
            this.Close();
        }

        private void btn_Administracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministracion admin = new FormAdministracion();
            admin.ShowDialog();
            this.Close();
        }

        private void btn_logueo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngreso ing = new FormIngreso();
            ing.ShowDialog();
            this.Close();
        }
    }
}
