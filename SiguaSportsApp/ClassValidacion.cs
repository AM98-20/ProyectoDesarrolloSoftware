using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace SiguaSportsApp
{

    //prueba complementaria
    class ClassValidacion
    {
        public bool Espacio_Blanco(ErrorProvider ubicacionError, TextBox txt)
        {
            bool Espacio_Blanco = true;

            foreach (char caracter in txt.Text)
            {
                if (!Char.IsWhiteSpace(caracter))
                {
                    Espacio_Blanco = false;
                    ubicacionError.SetError(txt, "");
                    break;
                }
                else
                {
                    Espacio_Blanco = true;
                }
            }
            return Espacio_Blanco;
        }
        public bool Espacio_Blanco(ErrorProvider ubicacionError, MaskedTextBox txt)
        {
            bool Espacio_Blanco = true;

            foreach (char caracter in txt.Text)
            {
                if (!Char.IsWhiteSpace(caracter))
                {
                    Espacio_Blanco = false;
                    ubicacionError.SetError(txt, "");
                    break;
                }
                else
                {
                    Espacio_Blanco = true;
                }
            }
            return Espacio_Blanco;
        }
        public bool Solo_Letras(ErrorProvider ubicacionError, TextBox txt)
        {
            bool soloLetras = true;
            foreach (char caracter in txt.Text)
            {
                if (Char.IsLetter(caracter))
                {
                    soloLetras = false;
                    ubicacionError.SetError(txt, "");
                }
                else if (char.IsWhiteSpace(caracter))
                {
                    soloLetras = false;
                    ubicacionError.SetError(txt, "");
                }
                else
                {
                    soloLetras = true;
                    break;
                }
            }
            return soloLetras;
        }

        public bool Solo_Numeros(ErrorProvider ubicacionError, TextBox txt)
        {
            bool Solo_Numeros = true;
            foreach (char caracter in txt.Text)
            {
                if (Char.IsDigit(caracter))
                {
                    Solo_Numeros = false;
                    ubicacionError.SetError(txt, "");
                }
                else
                {
                    Solo_Numeros = true;
                    break;
                }
            }
            return Solo_Numeros;
        }
        public bool Solo_Numeros1(ErrorProvider ubicacionError, TextBox txt)
        {
            bool Solo_Numeros = true;
            foreach (char caracter in txt.Text)
            {
                if (Char.IsDigit(caracter))
                {
                    Solo_Numeros = false;
                    ubicacionError.SetError(txt, "");
                }
                else if (char.IsPunctuation(caracter))
                {
                    Solo_Numeros = false;
                    ubicacionError.SetError(txt, "");
                }
                else
                {
                    Solo_Numeros = true;
                    break;
                }
            }
            return Solo_Numeros;
        }
    }
}
