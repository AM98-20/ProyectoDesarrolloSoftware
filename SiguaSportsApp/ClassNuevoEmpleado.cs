using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiguaSportsApp
{
    class ClassNuevoEmpleado
    {
        private static string cod_empleado;
        private static string nombre_empleado;
        private static string apellidos_empleado;
        private static string cod_usuario;
        private static string telefono;
        private static string genero;
        private static string fecha_naci;
        private static string correo;
        private static int codigoPuesto;
        private static int cod_genero;


        public string Cod_usuario { get => cod_usuario; set => cod_usuario = value; }
        public string Cod_empleado { get => cod_empleado; set => cod_empleado = value; }
        public string Nombre_empleado { get => nombre_empleado; set => nombre_empleado = value; }
        public string Apellidos_empleado { get => apellidos_empleado; set => apellidos_empleado = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Fecha_naci { get => fecha_naci; set => fecha_naci = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Cod_genero { get => cod_genero; set => cod_genero = value; }
        public int CodigoPuesto { get => codigoPuesto; set => codigoPuesto = value; }
    }
}
