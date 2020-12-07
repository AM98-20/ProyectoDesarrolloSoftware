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
    public partial class FormEmpleadoNuevo : Form
    {
        public FormEmpleadoNuevo()
        {
            InitializeComponent();
        }

        private void FormEmpleadoNuevo_Load(object sender, EventArgs e)
        {
            dtp_FechaNAc.MinDate = DateTime.Today.AddYears(-65);
            dtp_FechaNAc.MaxDate = DateTime.Today.AddYears(-21);
        }
        ClassValidacion validacion = new ClassValidacion();
        ClassConexionBD con = new ClassConexionBD();
        ClassNuevoEmpleado nuevo = new ClassNuevoEmpleado();

        private bool letra1 = false;
        private bool letra2 = false;
        private bool letra3 = false;
        private bool letra4 = false;
        private bool letra5 = false;
        private bool numero2 = false;

        public void validar()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtNombre) || validacion.Solo_Letras(ErrorProvider, txtNombre))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtNombre))
                    ErrorProvider.SetError(txtNombre, "No se puede dejar en blanco");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtNombre))
                    ErrorProvider.SetError(txtNombre, "Solo se permite letras");
            }
            else
            {
                letra1 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtApellidos) || validacion.Solo_Letras(ErrorProvider, txtApellidos))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtApellidos))
                    ErrorProvider.SetError(txtApellidos, "No se puede dejar en blanco");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtApellidos))
                    ErrorProvider.SetError(txtApellidos, "Solo se permite letras");
            }
            else
            {
                letra2 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txt_Usuario))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txt_Usuario))
                    ErrorProvider.SetError(txt_Usuario, "No se puede dejar en blanco");
            }
            else
            {
                letra3 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txt_Contrasena))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txt_Contrasena))
                    ErrorProvider.SetError(txt_Contrasena, "No se puede dejar en blanco");
            }
            else
            {
                letra4 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txt_Confirmacion))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txt_Confirmacion))
                    ErrorProvider.SetError(txt_Confirmacion, "No se puede dejar en blanco");
            }
            else if (txt_Confirmacion.Text.ToString() != txt_Contrasena.Text.ToString())
                ErrorProvider.SetError(txt_Confirmacion, "Las contraseñas no concierdan");
            else
            {
                letra5 = true;
            }

            mtxttelefono.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //arreglar
            if (validacion.Espacio_Blanco(ErrorProvider, mtxttelefono))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, mtxttelefono))
                    ErrorProvider.SetError(mtxttelefono, "No se puede dejar en blanco");
            }
            else
            {
                numero2 = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministracion admin = new FormAdministracion();
            admin.ShowDialog();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.cmd = new SqlCommand("if exists(Select cod_usuario from Usuarios where cod_usuario = '"+txt_Usuario.Text.ToString()+"') begin Select 'Existe' Mensaje end", con.sc);
            con.AbrirConexion();
            SqlDataReader lector = con.cmd.ExecuteReader();
            if (lector.Read())
            {
                con.CerrarConexion();
                MessageBox.Show("Ya existe el usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Focus();
                txt_Usuario.Text = "";
            }
            else
            {
                con.CerrarConexion();
                letra1 = false; letra2 = false; letra3 = false; letra4 = false; letra5 = false; numero2 = false;
                validar();
                if (letra1 && letra2 && letra3 && letra4 && letra5 && numero2)
                {
                    if (cb_Genero.SelectedIndex != -1 && cb_Puesto.SelectedIndex != -1)
                    {

                        int indiceGen = cb_Genero.SelectedIndex + 1;
                        int indicePos = cb_Puesto.SelectedIndex + 1;
                        string codEmp = txtNombre.Text.Substring(0, 3) + txtApellidos.Text.Substring(0, 3);
                        double salario = 0.00;

                        switch (indicePos)
                        {
                            case 1:
                                salario = 18500.00;
                                break;
                            case 2:
                                salario = 15350.00;
                                break;
                            case 3:
                                salario = 12600.00;
                                break;
                            default:
                                salario = 0.00;
                                break;
                        }

                        con.cmd = new SqlCommand("INSERT INTO Usuarios(cod_usuario, contraseña, confirmacion) " +
                            "values('" + txt_Usuario.Text.ToString() + "', '" + txt_Contrasena.Text.ToString() + "', '" + txt_Confirmacion.Text.ToString() + "')", con.sc);
                        try
                        {
                            con.AbrirConexion();
                            con.cmd.ExecuteNonQuery();
                            con.CerrarConexion();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR " + ex);
                        }

                        if (String.IsNullOrEmpty(txtCorreo.Text))
                        {
                            con.cmd = new SqlCommand("INSERT INTO Empleados(cod_empleado, nombres, apellidos, cod_puesto, cod_usuario, " +
                                "salario, fecha_contratacion, fecha_nacimiento, cod_genero, telefono) " +
                                "values('" + codEmp + "','" + txtNombre.Text.ToString() + "','" + txtApellidos.Text.ToString() + "','" + indicePos + "'," +
                                "'" + txt_Usuario.Text.ToString() + "','" + salario + "',GETDATE(),'" + dtp_FechaNAc.Value.ToString("yyy/MM/dd") + "','" + indiceGen + "'," +
                                "'" + mtxttelefono.Text.ToString() + "')", con.sc);
                        }
                        else
                        {
                            con.cmd = new SqlCommand("INSERT INTO Empleados(cod_empleado, nombres, apellidos, cod_puesto, cod_usuario, " +
                                "salario, fecha_contratacion, fecha_nacimiento, cod_genero, correo, telefono) " +
                                "values('" + codEmp + "', '" + txtNombre.Text.ToString() + "', '" + txtApellidos.Text.ToString() + "', '" + indicePos + "', " +
                                "'" + txt_Usuario.Text.ToString() + "', '" + salario + "', GETDATE(), '" + dtp_FechaNAc.Value.ToString("yyy/MM/dd") + "', '" + indiceGen + "', " +
                                "'" + txtCorreo.Text.ToString() + "', '" + mtxttelefono.Text.ToString() + "')", con.sc);
                        }

                        try
                        {
                            con.AbrirConexion();
                            con.cmd.ExecuteNonQuery();
                            con.CerrarConexion();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR " + ex);
                        }

                        txtNombre.Text = "";
                        txtApellidos.Text = "";
                        txtCorreo.Text = "";
                        txt_Confirmacion.Text = "";
                        txt_Contrasena.Text = "";
                        txt_Usuario.Text = "";
                        mtxttelefono.Text = "";
                        cb_Genero.SelectedIndex = -1;
                        cb_Puesto.SelectedIndex = -1;
                    }
                    else
                    {
                        if (cb_Genero.SelectedIndex != -1)
                            ErrorProvider.SetError(cb_Puesto, "Seleccione una opcion.");
                        if (cb_Puesto.SelectedIndex != -1)
                            ErrorProvider.SetError(cb_Genero, "Seleccione una opcion.");
                    }
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
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
            Application.Exit();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
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
    }
}
