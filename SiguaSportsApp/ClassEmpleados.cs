using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiguaSportsApp
{
    class ClassEmpleados
    {
        private static string cod_empleado;
        private static string nombre_empleado;
        private static string apellidos_empleado;        
        private static string cod_usuario;
        private static string telefono;        
        private static int codigoPuesto;

        public int CodigoPuesto { get => codigoPuesto; set => codigoPuesto = value; }
        public string Cod_usuario { get => cod_usuario; set => cod_usuario = value; }
        public string Cod_empleado { get => cod_empleado; set => cod_empleado = value; }
        public string Nombre_empleado { get => nombre_empleado; set => nombre_empleado = value; }
        public string Apellidos_empleado { get => apellidos_empleado; set => apellidos_empleado = value; }
        public string Telefono { get => telefono; set => telefono = value; }

    }
}
