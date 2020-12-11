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
    class ClassDatosTablas : ClassConexionBD
    {
        ClassEmpleados emp = new ClassEmpleados();
        public void CargarDatosTablas(DataGridView dvg, string query)
        {
            try
            {
                AbrirConexion();
                da = new SqlDataAdapter(query, sc);
                dt = new DataTable();
                da.Fill(dt);
                dvg.DataSource = dt;
                CerrarConexion();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudieron cargar los datos: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        public void CargarDatosCombo(ComboBox combo, string query)
        {
            cmd = new SqlCommand(query, sc);            
            try
            {
                AbrirConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                IList<string> modelList = new List<string>();
                while (dr.Read())
                {
                    combo.Items.Add(dr[0].ToString());
                }
                CerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: "+ ex);
            }            
        }

        public void EliminarEmpleado(DataGridView dgv, string codigo)
        {
            AbrirConexion();
            int flag = 0;
            sql = string.Format("Delete from EmpleadodHistoricos where Codigo = {0}", codigo);
            cmd = new SqlCommand(sql, sc);
            flag = cmd.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("La consulta se realizo correctamente. Se elimino el empleado, permanecera en la tabla empleados historicos.", 
                    "Empleado Historico", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show("No se encontro el empleado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CerrarConexion();
        }

        public void AgregarDatos(string codigo, int cantidad)
        {

            sql = "if exists(Select cod_producto from Productos where cod_producto = @codigo) begin " +
                "SELECT existencia, cod_producto [Codigo Producto], " +
                "CONCAT(nombre, ' ', marca, ' ', color) [Descripcion], precioVenta [Precio Unitario], " +
                "SUM(existencia - (existencia - @cantidad)) Cantidad FROM Productos P where cod_producto = @codigo " +
                "group by existencia, cod_producto, nombre, marca, color, precioVenta end";
            cmd = new SqlCommand(sql, sc);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            AbrirConexion();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ClassDatosTransaccion datos = new ClassDatosTransaccion();
                datos.Codigo = reader["Codigo Producto"].ToString();
                datos.Descripcion = reader["Descripcion"].ToString();
                datos.Precio = double.Parse(reader["Precio Unitario"].ToString());
                datos.Cantidad = int.Parse(reader["Cantidad"].ToString());
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            CerrarConexion();            
        }
    }
}
