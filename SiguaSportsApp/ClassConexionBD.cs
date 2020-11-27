using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace SiguaSportsApp
{
    class ClassConexionBD : ClassEmpleados
    {
        public SqlConnection sc = new SqlConnection();

        public SqlDataAdapter da;
        public DataTable dt;

        public string sql;
        public SqlCommand cmd;

        //PruebaPull

        //ARREGLAR CONEXION
        //string conexion = "Data Source = IP,Port; Network Library = DBMSSOCN; Initial Catalog = dbase; User ID=id; Password = password"
        //string conexion = "Server=(NombreServidor),(PuertoTCP/IP);DataBase=(NombreBase); User Id=(Usuario); Password=(Password)"

        //***NO CAMBIEN LA CONEXION, COMENTENLA Y AGREGUEN OTRA LINEA DE COMANDOS ***
        string conexion = "Data Source = .; Initial Catalog = SiguaSports; " + "Integrated Security = true";

        //conexion de jhonatan
        //string conexion = "Data Source = DESKTOP-B5ROQPH\\SQLEXPRESS; Initial Catalog = SiguaSports; " + "Integrated Security = true";

        public ClassConexionBD()
        {
            sc.ConnectionString = conexion;
        }
        public void AbrirConexion()
        {
            try
            {
                sc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR en la conexion" + ex, "Error de Conexion: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CerrarConexion()
        {
            sc.Close();
        }

        public bool Autentificacion(string usuario, string contra)
        {
            bool verificacion = false;

            sql = string.Format("SELECT E.cod_empleado Codigo, CONCAT(nombres, ' ', apellidos) Nombre, " +
                "E.cod_puesto Puesto, U.cod_usuario Usuario, U.contraseña Contraseña, E.cod_puesto [Codigo Puesto], " +
                "E.telefono Telefono FROM Empleados E inner join Usuarios U on E.cod_usuario = U.cod_usuario " +
                "where U.cod_usuario = '{0}' and U.contraseña = '{1}'", usuario, contra);
            cmd = new SqlCommand(sql, sc);
            

            try
            {
                AbrirConexion();
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    Nombre_empleado = lector["Nombre"].ToString();
                    CodigoPuesto = int.Parse(lector["Codigo Puesto"].ToString());
                    Cod_empleado = lector["Codigo"].ToString();
                    Cod_usuario = lector["Usuario"].ToString();

                    verificacion = true;
                    MessageBox.Show("Bienvenido!", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarConexion();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
           
            return verificacion;
        }

        public bool Confirmacion(string usuario, string contra)
        {
            bool verificacion = false;
            ClassConfirmacion conf = new ClassConfirmacion();

            sql = string.Format("SELECT E.cod_puesto [Codigo Puesto] FROM Empleados E inner join Usuarios U " +
                "on E.cod_usuario = U.cod_usuario where U.cod_usuario = '{0}' and U.contraseña = '{1}'", usuario, contra);
            cmd = new SqlCommand(sql, sc);
            sc.Open();

            try
            {
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    conf.CodigoPuesto = int.Parse(lector["Codigo Puesto"].ToString());

                    verificacion = true;
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
            CerrarConexion();
            return verificacion;
        }

        public string FacturaVenta()
        {
            string mensaje = "";
            AbrirConexion();
            cmd = new SqlCommand("declare @cod varchar(18) execute [dbo].[CodFactura] @cod output select @cod Codigo", sc);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                mensaje = reader["Codigo"].ToString();
            }
            CerrarConexion();
            return mensaje;
        }

        public string DevolucionCodigo()
        {
            string mensaje = "";
            AbrirConexion();
            cmd = new SqlCommand("SELECT top 1 COUNT(*)+1 Codigo FROM Devoluciones", sc);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                mensaje = reader["Codigo"].ToString();
            }
            CerrarConexion();
            return mensaje;
        }

        public string BuscarDev( string Factura)
        {
            string mensaje = "";

            cmd = new SqlCommand("if exists(SELECT num_factura FROM Ventas where num_factura = '" + Factura + "') begin Select 'Existe' Mensaje end else begin Select 'No existe' Mensaje end", sc);
            AbrirConexion();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                mensaje = reader["Mensaje"].ToString();
            }

            CerrarConexion();

            return mensaje;
        }
    }
}

