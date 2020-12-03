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
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            
            
        }

        private void lblContrasenaOlvidada_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contactese con un gerente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcontraseñalogin_TextChanged(object sender, EventArgs e)
        {
            //txtcontraseñalogin.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVentas ventas = new FormVentas();
            ventas.Show();
        }     

        private void btningresar_Click(object sender, EventArgs e)
        {
            ClassValidacion validacion = new ClassValidacion();
            ClassConexionBD autentificar = new ClassConexionBD();            

            if (validacion.Espacio_Blanco(ErrorProvider, txtcontraseñalogin) || validacion.Espacio_Blanco(ErrorProvider, txtUsuario))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtcontraseñalogin))
                {
                    if (!validacion.Espacio_Blanco(ErrorProvider, txtUsuario))
                    {
                        ErrorProvider.SetError(txtUsuario, "");
                    }
                    ErrorProvider.SetError(txtcontraseñalogin, "No se ingreso una contraseña.");
                }
                if (validacion.Espacio_Blanco(ErrorProvider, txtUsuario))
                {
                    if (!validacion.Espacio_Blanco(ErrorProvider, txtcontraseñalogin))
                    {
                        ErrorProvider.SetError(txtcontraseñalogin, "");
                    }
                    ErrorProvider.SetError(txtUsuario, "No se ingreso un usuario.");
                }
            }
            else
            {
                if (autentificar.Autentificacion(txtUsuario.Text.ToString(), txtcontraseñalogin.Text.ToString()) == true)
                {
                    try
                    {
                        int codigo = autentificar.CodigoPuesto;
                        
                        this.Hide();
                        if (codigo == 3)
                        {
                            FormVentas ventas = new FormVentas();
                            ventas.ShowDialog();
                        }
                        else if (codigo == 1)
                        {
                            FormAdministracion admin = new FormAdministracion();
                            admin.ShowDialog();
                        }
                        else
                        {
                            FormRegistroBodega bodega = new FormRegistroBodega();
                            bodega.ShowDialog();
                        }
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
            }                     
        }

        private void txtcontraseñalogin_TextChanged_1(object sender, EventArgs e)
        {
            txtcontraseñalogin.UseSystemPasswordChar = true;
            chkMostrar.Checked = false;
        }

        private void lblContrasenaOlvidada_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Contactese con un gerente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkMostrar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkMostrar.Checked == true)
            {
                txtcontraseñalogin.UseSystemPasswordChar = false;
            }
            else
            {
                txtcontraseñalogin.UseSystemPasswordChar = true;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
