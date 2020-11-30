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
    public partial class FormEmpleadoEgreso : Form
    {
        public FormEmpleadoEgreso()
        {
            InitializeComponent();
        }

        private void FormEmpleadoEgreso_Load(object sender, EventArgs e)
        {
            tabla.CargarDatosTablas(dgvEgreso, query);
        }

        ClassConexionBD conex = new ClassConexionBD();
        ClassDatosTablas tabla = new ClassDatosTablas();

        string query = "SELECT cod_empleado Codigo, CONCAT(nombres, ' ', apellidos) Nombre, p.descripcion Puesto, " +
            "cod_usuario Usuario, salario Salario, fecha_contratacion [Fecha Contratacion], telefono Telefono " +
            "FROM Empleados e inner join Puestos p on e.cod_puesto = p.cod_puesto";

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministracion admin = new FormAdministracion();
            admin.ShowDialog();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = dgvEgreso.CurrentCell.RowIndex;
                string codigo = dgvEgreso.Rows[indice].Cells["Codigo"].Value.ToString();

                conex.cmd = new SqlCommand("DELETE FROM Empleados WHERE cod_empleado = '" + codigo + "'", conex.sc);

                conex.AbrirConexion();
                conex.cmd.ExecuteNonQuery();
                conex.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
            }
            tabla.CargarDatosTablas(dgvEgreso, query);
        }

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

        private void btn_Administracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministracion admin = new FormAdministracion();
            admin.ShowDialog();
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
    }
}