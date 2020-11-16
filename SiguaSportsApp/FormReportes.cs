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

        }
        ClassConexionBD con = new ClassConexionBD();

        private void bnt_Buscar_Click(object sender, EventArgs e)
        {
            //revisar
            con.da = new SqlDataAdapter("WITH ReporteFinanciero AS" +
                "(SELECT [Mes] = MONTH(fecha_Venta),[Ventas Brutas] = SUM(vd.precioVenta * vd.cantidad)," +
                "[Compras Brutas] = SUM(cd.precioCompra * cd.cantidad)," +
                "[Ventas Brutas Mes Pasado] = LAG(SUM(vd.precioVenta * vd.cantidad)) " +
                "OVER (ORDER BY MONTH(fecha_Venta)) FROM Ventas v " +
                "inner join VentaDetalle vd on v.num_factura = vd.num_factura " +
                "inner join CompraDetalle cd on vd. cod_prducto = cd.cod_compra " +
                "where fecha_Venta between '"+dtpFecha1.Value.ToShortDateString()+ "' and '"+dtpFecha1.Value.ToShortDateString()+"' " +
                "GROUP BY MONTH(fecha_Venta)) " +
                "SELECT [Mes],[Ventas Brutas],[Ventas Brutas Mes Pasado]," +
                "[Crecimiento Mensual] = 100.0 * ([Ventas Brutas] - [Ventas Brutas Mes Pasado])/ [Ventas Brutas Mes Pasado]," +
                "[Compras Brutas],[Utilidad Bruta] = ([Ventas Brutas] - [Compras Brutas])FROM [ReporteFinanciero] ORDER BY [Mes]", con.sc);
            con.AbrirConexion();
            con.dt = new DataTable();
            con.da.Fill(con.dt);
            dgvReporteFinanciero.DataSource = con.dt;
            con.CerrarConexion();
        }

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

        private void btn_salir_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            
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
            btn_maximizar.Visible = true;
        }
    }
}
