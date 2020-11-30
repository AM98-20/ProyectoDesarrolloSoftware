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
    public partial class FormConfirmacion : Form
    {
        public FormConfirmacion()
        {
            InitializeComponent();
        }
        private void FormConfirmacion_Load(object sender, EventArgs e)
        {

        }

        ClassDatosTransaccion tran = new ClassDatosTransaccion();

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ClassValidacion validacion = new ClassValidacion();
            ClassConexionBD autentificar = new ClassConexionBD();

            if (validacion.Espacio_Blanco(ErrorProvider, txtContraseña) || validacion.Espacio_Blanco(ErrorProvider, txtUsuario))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtContraseña))
                {
                    if (!validacion.Espacio_Blanco(ErrorProvider, txtUsuario))
                    {
                        ErrorProvider.SetError(txtUsuario, "");
                    }
                    ErrorProvider.SetError(txtContraseña, "No se ingreso una contraseña.");
                }
                if (validacion.Espacio_Blanco(ErrorProvider, txtUsuario))
                {
                    if (!validacion.Espacio_Blanco(ErrorProvider, txtContraseña))
                    {
                        ErrorProvider.SetError(txtContraseña, "");
                    }
                    ErrorProvider.SetError(txtUsuario, "No se ingreso un usuario.");
                }
            }
            else
            {
                if (autentificar.Confirmacion(txtUsuario.Text.ToString(), txtContraseña.Text.ToString()) == true)
                {
                    ClassConfirmacion confirmacion = new ClassConfirmacion();
                    if (confirmacion.CodigoPuesto == 1)
                    {
                        tran.CodConf = 2;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso no autorizado.", "Acceso Restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Hide();
                    }              
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
