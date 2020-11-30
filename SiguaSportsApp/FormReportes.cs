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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            dtpFecha1.MaxDate = DateTime.Today.AddDays(-1);
            dtpFecha2.MaxDate = DateTime.Today;
            datos.CargarDatosTablas(dgv_ReporteDiario, query);
        }
        ClassConexionBD con = new ClassConexionBD();
        ClassDatosTablas datos = new ClassDatosTablas();

        string query = "SELECT case when v.num_factura is null then 'Total' else v.num_factura end Factura, SUM(vd.cantidad * vd.precioVenta)Total " +
            "FROM Ventas v inner join VentaDetalle vd on v.num_factura = vd.num_factura WHERE v.fecha_Venta = GETDATE() GROUP BY v.num_factura WITH ROLLUP ";

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministracion admin = new FormAdministracion();
            admin.ShowDialog();
            this.Close();
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

        private void boton_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boton_max_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            boton_max.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void boton_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void boton_restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            boton_restaurar.Visible = false;
            boton_max.Visible = true;
        }

        private void btn_Inventario_bodega_Click(object sender, EventArgs e)
        {
            FormInventarioBodega inven_bode = new FormInventarioBodega();
            inven_bode.ShowDialog();
            this.Close();
        }

        private void btn_Registro_bodega_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistroBodega reg = new FormRegistroBodega();
            reg.ShowDialog();
            this.Close();
        }

        private void btn_logueo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngreso ing = new FormIngreso();
            ing.ShowDialog();
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            boton_max.Visible = true;
        }

        private void bnt_Buscar_Click(object sender, EventArgs e)
        {
            con.da = new SqlDataAdapter("WITH ReporteFinanciero AS (SELECT " +
                "[Mes]						= MONTH(fecha_Venta)," +
                "[Ventas Brutas]			= SUM(vd.precioVenta * vd.cantidad), " +
                "[Ventas Brutas Mes Pasado]	= LAG(SUM(vd.precioVenta * vd.cantidad)) OVER (ORDER BY MONTH(fecha_Venta)) " +
                "FROM Ventas v inner join VentaDetalle vd on v.num_factura = vd.num_factura " +
                "where fecha_Venta between '" + dtpFecha1.Value.ToShortDateString() + "' and '" + dtpFecha2.Value.ToShortDateString() + "' " +
                "GROUP BY MONTH(fecha_Venta)) " +
                "SELECT [Mes],[Ventas Brutas],[Ventas Brutas Mes Pasado],[Crecimiento Mensual] = 100.0 * ([Ventas Brutas] - [Ventas Brutas Mes Pasado])/ [Ventas Brutas Mes Pasado]FROM [ReporteFinanciero] " +
                "ORDER BY [Mes]", con.sc);
            try
            {
                con.AbrirConexion();
                con.dt = new DataTable();
                con.da.Fill(con.dt);
                dgvReporteFinanciero.DataSource = con.dt;
                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
    }//Form
}//Class
