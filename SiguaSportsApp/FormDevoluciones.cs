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
                                         "FROM DevolucionDetalle A INNER JOIN Productos B ON A.cod_producto = B.cod_producto " +
                                         "INNER JOIN Devoluciones C ON A.num_devolucion = C.num_devolucion where cod_estado = '1'";

        double des = 0.0;
        double imp = 0.0;

        private void FromDevoluciones_Load(object sender, EventArgs e)
        {
            conexion.CargarDatosTablas(dgv_Historial, query);
            txtDevolucion.Text = conexion.DevolucionCodigo();
            txtvendedor.Text = conexion.Nombre_empleado;
            btn_Buscar.Visible = true;
            tran.Subtotal = 0.00;
            tran.Descuento = 0.00;
            tran.Impuesto = 0.00;
            tran.TotalDevolucion = 0.00;          
        }        

        ClassValidacion validacion = new ClassValidacion();
        ClassDatosTransaccion tran = new ClassDatosTransaccion();
        ClassConexionBD con = new ClassConexionBD();
        ClassDatosTransaccion datos = new ClassDatosTransaccion();        

        bool letra2 = false;
        bool factura = false;

        public void validar1()
        {
            mtb_Factura.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //arreglar
            if (validacion.Espacio_Blanco(ErrorProvider, mtb_Factura))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, mtb_Factura))
                    ErrorProvider.SetError(mtb_Factura, "No se puede dejar en blanco");
            }
            else
            {
                factura = true;
                mtb_Factura.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
        }

        public void validar()
        {

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

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            factura = false;
            validar1();            
            if (factura)
            {                
                string Mensaje = conexion.BuscarDev(mtb_Factura.Text.ToString());
                int Dias = 0;

                if (Mensaje == "Existe")
                {
                    validar();
                    if (letra2) {
                        nud_Cantidad.Enabled = true;
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
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR " + ex);
                        }

                        if (Dias < 3)
                        {
                            btn_Buscar.Visible = false;
                            mtb_Factura.Enabled = false;
                            dgvDevoluciones.Enabled = true;
                            /////////////////
                            string query1 = "SELECT cod_prducto Producto, CONCAT(p.nombre, ' ', p.marca, ' ', p.color) Descripción, cantidad [Cantidad Vendida], vd.precioVenta Precio " +
                                    "FROM Ventas v inner join VentaDetalle vd on v.num_factura = vd.num_factura inner join Productos p on vd.cod_prducto = p.cod_producto " +
                                    "where v.num_factura = '" + mtb_Factura.Text.ToString() + "'";
                            conexion.CargarDatosTablas(dgvDevoluciones, query1);

                            con.cmd = new SqlCommand("SELECT v.descuentoPorcentaje Descuento, v.impuestoPorcentaje Impuesto FROM Ventas v inner join VentaDetalle vd on v.num_factura = vd.num_factura " +
                                "inner join Productos p on vd.cod_prducto = p.cod_producto where v.num_factura = '" + mtb_Factura.Text.ToString() + "'", con.sc);
                            try
                            {
                                con.AbrirConexion();
                                SqlDataReader rd = con.cmd.ExecuteReader();
                                if (rd.Read())
                                {
                                    tran.Descuento = tran.Subtotal * des;
                                    tran.Impuesto = tran.Subtotal * imp;
                                }
                                con.CerrarConexion();
                            }catch (Exception E)
                            {
                                MessageBox.Show(""+E);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("La fecha de venta excedio la fecha limite de devolucion.", "Limite excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error, no se encontro la factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                               
            }            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgv_ProdDev.Rows.Count == 0)
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
                        "values('" + txtDevolucion.Text.ToString() + "',@codProd,@cantidad,@motivo,'1')", conexion.sc);
                    foreach (DataGridViewRow row in dgv_ProdDev.Rows)
                    {
                        conexion.cmd.Parameters.Clear();

                        conexion.cmd.Parameters.AddWithValue("@codProd", Convert.ToString(row.Cells["columnaCodigo"].Value));
                        conexion.cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["columnaCantidad"].Value));
                        conexion.cmd.Parameters.AddWithValue("@motivo", Convert.ToString(row.Cells["columnaMotivo"].Value));
                        
                        conexion.AbrirConexion();
                        conexion.cmd.ExecuteNonQuery();
                        conexion.CerrarConexion();
                    }

                    DialogResult result = MessageBox.Show("Se ingresara devulta al inventario?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        conexion.cmd = new SqlCommand("UPDATE Productos set existencia = existencia + @cantidad where cod_producto = @codProd", conexion.sc);
                        foreach (DataGridViewRow row in dgv_ProdDev.Rows)
                        {
                            conexion.cmd.Parameters.Clear();

                            conexion.cmd.Parameters.AddWithValue("@codProd", Convert.ToString(row.Cells["columnaCodigo"].Value));
                            conexion.cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["columnaCantidad"].Value));
                            conexion.AbrirConexion();
                            conexion.cmd.ExecuteNonQuery();
                            conexion.CerrarConexion();
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
                    this.Hide();
                    FormDevoluciones dev = new FormDevoluciones();
                    dev.ShowDialog();
                    this.Close();
                }
            }
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

        private void dgvDevoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDevoluciones.CurrentCell.RowIndex;
            DataGridViewRow sr = dgvDevoluciones.Rows[index];
            nud_Cantidad.Maximum = int.Parse(sr.Cells["Cantidad Vendida"].Value.ToString());
        }

        private void dgvDevoluciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] arr;
            tran.Total = 0.00;
            tran.TotalDevolucion = 0.00;
            int index = dgvDevoluciones.CurrentCell.RowIndex;
            DataGridViewRow sr = dgvDevoluciones.Rows[index];
            
            for (int i = 0; i < dgvDevoluciones.Rows.Count; i++)
            {
                if (i == index)
                {                    
                    arr = new[] { sr.Cells["Producto"].Value.ToString(), sr.Cells["Precio"].Value.ToString(), nud_Cantidad.Value.ToString(), txtMotivo.Text.ToString() };
                    dgv_ProdDev.Rows.Add(arr);
                    dgv_ProdDev.Visible = true;
                    dgvDevoluciones.Visible = false;
                    dgvDevoluciones.Rows.RemoveAt(i);
                    btnAgregar.Visible = true;
                }
            }

            validar();
            if (letra2)
            {
                letra2 = false;
                try
                {
                    tran.Subtotal = 0.00;
                    tran.Descuento = 0.00;
                    tran.Impuesto = 0.00;
                    tran.TotalDevolucion = 0.00;

                    foreach (DataGridViewRow row in dgv_ProdDev.Rows)
                    {
                        double precio = double.Parse(row.Cells["columnaPrecio"].Value.ToString());
                        int cantidad = int.Parse(row.Cells["columnaCantidad"].Value.ToString());
                        double totalUnit = precio * cantidad;
                        datos.Subtotal += totalUnit;
                    }

                    
                    tran.CalculoTotalDevolucion();
                    txttotal.Text = tran.TotalDevolucion.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el motivo de devolucion y cambio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvDevoluciones.Visible = true;
            dgv_ProdDev.Visible = false;
            btnAgregar.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }
    }
}
