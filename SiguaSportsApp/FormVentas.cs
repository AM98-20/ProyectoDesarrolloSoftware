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
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            txtfactura.Text = con.FacturaVenta();
            txtvendedor.Text = con.Nombre_empleado;
            datos.NumFactura = txtfactura.Text.ToString();
            datos.FechaTransaccion = dtp_FechaVenta.Value.ToShortDateString();
            datos.IdVendedor = datos.Cod_empleado;
        }

        ClassDatosTablas datosTablas = new ClassDatosTablas();
        ClassDatosTransaccion datos = new ClassDatosTransaccion();
        ClassValidacion validacion = new ClassValidacion();
        ClassConexionBD con = new ClassConexionBD();
        bool letra1 = false;
        bool numero2 = false;

        public void validar()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtcodigoproducto))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtcodigoproducto))
                    ErrorProvider.SetError(txtcodigoproducto, "No se puede dejar en blanco");
            }
            else
            {
                letra1 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtcantidad))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtcantidad))
                    ErrorProvider.SetError(txtcantidad, "No se puede dejar en blanco");
                else
                if (validacion.Solo_Numeros(ErrorProvider, txtcantidad))
                    ErrorProvider.SetError(txtcantidad, "Solo se permite letras");
            }
            else
            {
                numero2 = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCambio cambio = new FormCambio();
            cambio.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cancelar la compra?", "Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                dgvventas.Rows.Clear();
            }
        }

        private void btn_AgregarProd_Click(object sender, EventArgs e)
        {
            string nMensaje;
            con.cmd = new SqlCommand("if exists(SELECT cod_producto FROM Productos where cod_producto = '"+txtcodigoproducto.Text.ToString()+"') begin SELECT 'Existe' Mensaje end", con.sc);
            con.AbrirConexion();
            SqlDataReader read = con.cmd.ExecuteReader();
            if (read.Read())
            {
                nMensaje = read["Mensaje"].ToString();
            }
            else
            {
                nMensaje = "No existe";
            }
            con.CerrarConexion();

            if (nMensaje == "Existe") {
                numero2 = false; letra1 = false;
                validar();
                if (numero2 && letra1)
                {
                    datosTablas.AgregarDatos(txtcodigoproducto.Text.ToString(), int.Parse(txtcantidad.Text.ToString()));
                    dgvventas.Rows.Add(datos.Codigo, datos.Descripcion, datos.Precio, datos.Cantidad.ToString(), (datos.Precio * datos.Cantidad).ToString());

                    foreach (DataGridViewRow row in dgvventas.Rows)
                    {
                        double precio = (double)row.Cells["columna_precio"].Value;
                        int cantidad = int.Parse(row.Cells["columna_cantidad"].Value.ToString());
                        double totalUnit = precio * cantidad;
                        datos.Subtotal += totalUnit;
                    }

                    datos.CalculoDescuento();
                    datos.CalculoImpuesto();
                    datos.CalculoTotal();
                    txtSubtotal.Text = datos.Subtotal.ToString();
                    txtDescuento.Text = datos.Descuento.ToString();
                    txtImpuesto.Text = datos.Impuesto.ToString();
                    txttotal.Text = datos.Total.ToString();
                    txtcodigoproducto.Text = "";
                    txtcantidad.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show(""+nMensaje+" el producto en inventario.", "Producto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_menu_Click_1(object sender, EventArgs e)
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

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Administracion_Click(object sender, EventArgs e)
        {
            if(datos.CodigoPuesto == 1)
            {
                this.Hide();
                FormAdministracion adm = new FormAdministracion();
                adm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado. Solo los administradores pueden acceder.", "Acceso Restringido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_restaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_Devoluciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDevoluciones dev = new FormDevoluciones();
            dev.ShowDialog();
            this.Close();
        }

        private void btn_Cambio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCambio cam = new FormCambio();
            cam.ShowDialog();
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("Desea finalizar la compra?", "Finalizar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result== DialogResult.Yes)
            {               
                try
                {
                    con.cmd = new SqlCommand("INSERT INTO Ventas(num_factura, cod_empleado, descuentoPorcentaje, impuestoPorcentaje, fecha_Venta) " +
                        "values('" + txtfactura.Text.ToString() + "', '" + con.Cod_empleado + "', " + datos.PorcentajeDes + ", " + datos.PorcentajeImp + ", '" + dtp_FechaVenta.Value.ToShortDateString() + "')", con.sc);
                    con.AbrirConexion();
                    con.cmd.ExecuteNonQuery();
                    con.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex, "ERROR");
                }

                con.cmd = new SqlCommand("INSERT INTO VentaDetalle(num_factura, cod_prducto, cantidad, precioVenta) " +
                        "values('" + txtfactura.Text.ToString() + "',@codProd,@cantidad,@precio)", con.sc);

                
                foreach (DataGridViewRow row in dgvventas.Rows)
                {
                    try
                    {
                        con.cmd.Parameters.Clear();

                        con.cmd.Parameters.AddWithValue("@codProd", Convert.ToString(row.Cells["columna_codigo"].Value));
                        con.cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["columna_cantidad"].Value));
                        con.cmd.Parameters.AddWithValue("@precio", Convert.ToString(row.Cells["columna_precio"].Value));
                        con.AbrirConexion();
                        con.cmd.ExecuteNonQuery();
                        con.CerrarConexion();
                    }catch (Exception ex)
                    {
                        MessageBox.Show("ERROR " + ex, "ERROR");
                    }
                }

                con.cmd = new SqlCommand("UPDATE Productos set existencia = existencia - @cantidad " +
                        "where cod_producto = @codigo", con.sc);

                foreach (DataGridViewRow row in dgvventas.Rows)
                {
                    try
                    {
                        con.cmd.Parameters.Clear();
                        con.cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["columna_cantidad"].Value));
                        con.cmd.Parameters.AddWithValue("@codigo", Convert.ToString(row.Cells["columna_codigo"].Value));
                        con.AbrirConexion();
                        con.cmd.ExecuteNonQuery();
                        con.CerrarConexion();
                    }catch (Exception ex)
                    {
                    MessageBox.Show("ERROR " + ex, "ERROR");
                    }
                }

                FromWindow reporte = new FromWindow();
                reporte.ShowDialog();
                
                FormVentas ven = new FormVentas();
                ven.ShowDialog();
            }
            else
            {                
                txtcantidad.Text = "";
                txtcodigoproducto.Text = "";
                dgvventas.Rows.Clear();
                return;
            }
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
