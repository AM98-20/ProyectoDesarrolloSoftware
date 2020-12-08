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

        ClassDatosTablas datos = new ClassDatosTablas();

        string query = "SELECT B.nombre[Producto] , A.cantidad[Cantidad] , A.motivo[Motivo] ,C.fecha_devolucion[Fecha de Devolución], A.cod_producto_cambio [Producto Cambio]" +
                                         "FROM DevolucionDetalle A INNER JOIN Productos B ON A.cod_producto = B.cod_producto " +
                                         "INNER JOIN Devoluciones C ON A.num_devolucion = C.num_devolucion where cod_estado = '2'";

        private void FormCambio_Load(object sender, EventArgs e)
        {
            datos.CargarDatosTablas(dgv_Historial, query);
            txtDevolucion.Text = con.DevolucionCodigo();
            txtvendedor.Text = con.Nombre_empleado;
            btn_Buscar.Visible = true;
            tran.Subtotal = 0.00;
            tran.Descuento = 0.00;
            tran.Impuesto = 0.00;
            tran.TotalDevolucion = 0.00;
        }

        ClassConexionBD con = new ClassConexionBD();
        ClassDatosTransaccion tran = new ClassDatosTransaccion();
        ClassValidacion validacion = new ClassValidacion();
        ClassDatosTablas tabla = new ClassDatosTablas();

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
            FormVentas ventas= new FormVentas();
            ventas.ShowDialog();
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

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {            
            factura = false;
            validar1();
            if (factura)
            {
                string Mensaje = con.BuscarDev(mtb_Factura.Text.ToString());
                int Dias = 0;

                if (Mensaje == "Existe")
                {
                    validar();
                    if (letra2) {
                        nud_Cantidad.Enabled = true;
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

                        if (Dias < 3)
                        {
                            dgvCambio.Enabled = true;
                            btn_Buscar.Visible = false;
                            mtb_Factura.Enabled = false;
                            /////////////
                            string query = "SELECT cod_prducto Producto, CONCAT(p.nombre, ' ', p.marca, ' ', p.color) Descripción, cantidad [Cantidad Vendida], vd.precioVenta Precio " +
                                "FROM Ventas v inner join VentaDetalle vd on v.num_factura = vd.num_factura inner join Productos p on vd.cod_prducto = p.cod_producto " +
                                "where v.num_factura = '" + mtb_Factura.Text.ToString() + "'";
                            tabla.CargarDatosTablas(dgvCambio, query);
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
            if (dgv_ProdCambio.Rows.Count == 0)
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
                    //Revision de Form de cambios
                    con.cmd = new SqlCommand("INSERT INTO DevolucionDetalle(num_devolucion, cod_producto, cantidad, motivo, cod_estado, cod_producto_cambio) " +
                        "values('" + txtDevolucion.Text.ToString() + "',@codProd,@cantidad,@motivo,'2', @codProd)", con.sc);
                    foreach (DataGridViewRow row in dgv_ProdCambio.Rows)
                    {
                        con.cmd.Parameters.Clear();

                        con.cmd.Parameters.AddWithValue("@codProd", Convert.ToString(row.Cells["columnaCodigo"].Value));
                        con.cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["columnaCantidad"].Value));
                        con.cmd.Parameters.AddWithValue("@motivo", Convert.ToString(row.Cells["columnaMotivo"].Value));
                        try
                        {
                            con.AbrirConexion();
                            con.cmd.ExecuteNonQuery();
                            con.CerrarConexion();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex);
                        }

                    }

                    DialogResult result = MessageBox.Show("Se reingresara producto al inventario?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        con.cmd = new SqlCommand("UPDATE Productos set existencia = existencia + @cantidad where cod_producto = @codProd", con.sc);
                        foreach (DataGridViewRow row in dgv_ProdCambio.Rows)
                        {
                            con.cmd.Parameters.Clear();

                            con.cmd.Parameters.AddWithValue("@codProd", Convert.ToString(row.Cells["columnaCodigo"].Value));
                            con.cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["columnaCantidad"].Value));
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
                    this.Hide();
                    FormDevoluciones dev = new FormDevoluciones();
                    dev.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormVentas venta = new FormVentas();
            venta.ShowDialog();
            this.Close();
        }

        private void dgvCambio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] arr;
            tran.Total = 0.00;
            tran.TotalDevolucion = 0.00;
            int index = dgvCambio.CurrentCell.RowIndex;
            DataGridViewRow sr = dgvCambio.Rows[index];
            
            for (int i = 0; i < dgvCambio.Rows.Count; i++)
            {
                if(i == index)
                {
                    arr = new[] {sr.Cells["Producto"].Value.ToString(), nud_Cantidad.Value.ToString(), txtMotivo.Text.ToString(), sr.Cells["Producto"].Value.ToString()};
                    dgv_ProdCambio.Rows.Add(arr);
                    dgv_ProdCambio.Visible = true;
                    dgvCambio.Visible = false;
                    dgvCambio.Rows.RemoveAt(i);
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
            else
            {
                MessageBox.Show("Ingrese el motivo de devolucion y cambio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCambio_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCambio.CurrentCell.RowIndex;
            DataGridViewRow sr = dgvCambio.Rows[index];
            nud_Cantidad.Maximum = int.Parse(sr.Cells["Cantidad Vendida"].Value.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvCambio.Visible = true;
            dgv_ProdCambio.Visible = false;
            btnAgregar.Visible = false;
        }
    }
}
