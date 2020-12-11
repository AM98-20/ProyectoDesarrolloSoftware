using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SiguaSportsApp
{
    public partial class FormInventarioBodega : Form
    {
        public FormInventarioBodega()
        {
            InitializeComponent();
        }
        string query = "SELECT cod_producto Codigo, CONCAT(p.nombre, ' ', color,  ' ', marca) Descripcion, " +
            "precioCompra [Precio de Compra], precioVenta [Precio de Venta], c.descripcion Categoria, p.existencia Existencia " +
            "FROM Productos p inner join Categorias c on p.cod_categoria = c.cod_categoria";
        private void FormInventarioBodega_Load(object sender, EventArgs e)
        {
            if (datos.CodigoPuesto == 3)
            {
                btn_reportes.Hide();
                btn_Registro_bodega.Hide();
            }
            if(datos.CodigoPuesto==2)
            {
                btn_Devoluciones.Hide();
            }            
            datos.CargarDatosTablas(dgvProductos, query);
        }

        ClassDatosTablas datos = new ClassDatosTablas();
        ClassConexionBD con = new ClassConexionBD();

        private void btn_menu_Click(object sender, EventArgs e)
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

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            boton_restaurar.Visible = true;
        }

        private void btn_Administracion_Click(object sender, EventArgs e)
        {
            if (datos.CodigoPuesto == 1)
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

        private void boton_restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            boton_restaurar.Visible = false;
            btn_maximizar.Visible = true;        
        }

        private void btn_Devoluciones_Click(object sender, EventArgs e)
        {                      
            this.Hide();
            FormDevoluciones dev = new FormDevoluciones();
            dev.ShowDialog();
            this.Close();
        }

        private void boton_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boton_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_restaurar_dos_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            datos.CargarDatosTablas(dgvProductos, query);            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtBuscar.Text.ToString();

            try
            {
                con.da = new SqlDataAdapter("exec filtroProductos @texto = '"+parametro+"'", con.sc);
                //aplicar  exec filtroProductos @texto = '"++"' 
                //en key press event o text change

                con.dt = new DataTable();
                con.da.Fill(con.dt);
                dgvProductos.DataSource = (con.dt);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cargar datos" + error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
