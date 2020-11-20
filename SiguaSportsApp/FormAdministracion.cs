using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiguaSportsApp
{
    public partial class FormAdministracion : Form
    {
        public FormAdministracion()
        {
            InitializeComponent();
        }

        private void FormAdministracion_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleadoNuevo ingreso = new FormEmpleadoNuevo();
            ingreso.ShowDialog();
            this.Close();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleadoEgreso egreso = new FormEmpleadoEgreso();
            egreso.ShowDialog();
            this.Close();
        }

        private void btnHistorialEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleadosHistorial histo = new FormEmpleadosHistorial();
            histo.ShowDialog();
            this.Close();
        }

        private void btnReporteFinanciero_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReportes repos = new FormReportes();
            repos.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if(SideBar.Width == 280)
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
                SideBar.Width = 280;
                contenedor_menu.Width = 222;
                linea_sidebar.Width = 198;
                expandir_menu.Show(SideBar);
            }
        }

        private void btn_logueo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngreso ing = new FormIngreso();
            ing.ShowDialog();
            this.Close();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReportes repos = new FormReportes();
            repos.ShowDialog();
            this.Close();
        }

        private void btn_Registro_bodega_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistroBodega reg = new FormRegistroBodega();
            reg.ShowDialog();
            this.Close();
        }

        private void btn_Inventario_bodega_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventarioBodega inv = new FormInventarioBodega();
            inv.ShowDialog();
            this.Close();
        }

        private void btn_Cambio_Click(object sender, EventArgs e)
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

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentas venticas = new FormVentas();
            venticas.ShowDialog();
            this.Close();
        }
    }
}
