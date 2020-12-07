using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiguaSportsApp
{
    class ClassDatosTransaccion : ClassConexionBD
    {
        private static double subtotal = 0;
        private static double descuento = 0;
        private static double impuesto = 0;
        private static double total = 0;
        private static double totalDevolucion = 0;
        private static string fechaTransaccion = DateTime.Today.ToShortDateString();
        private static string numFactura = "";
        private static string idVendedor  = "";

        private static string codigo;
        private static string descripcion;
        private static double precio;
        private static int cantidad;

        private static double porcentajeImp = 0;
        private static double porcentajeDes = 0;

        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Impuesto { get => impuesto; set => impuesto = value; }
        public double Total { get => total; set => total = value; }
        public double TotalDevolucion { get => totalDevolucion; set => totalDevolucion = value; }
        public string FechaTransaccion { get => fechaTransaccion; set => fechaTransaccion = value; }
        public string NumFactura { get => numFactura; set => numFactura = value; }
        public string IdVendedor { get => idVendedor; set => idVendedor = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double PorcentajeImp { get => porcentajeImp; set => porcentajeImp = value; }
        public double PorcentajeDes { get => porcentajeDes; set => porcentajeDes = value; }
        public int CodConf { get => codConf; set => codConf = value; }

        private static int codConf = 1;

        public void CalculoDescuento()
        {
            if (subtotal > 2000.00)
            {
                descuento = subtotal * 0.05;
                porcentajeDes = 5;
            }
            else
            {
                descuento = 0.00;
                porcentajeDes = 0;
            }  
        }

        public void CalculoImpuesto()
        {
            impuesto = subtotal * 0.15;
            porcentajeImp = 15;            
        }

        public void CalculoTotal()
        {
            total = subtotal - descuento + impuesto;
            totalDevolucion = total;
        }

        public void CalculoTotalDevolucion()
        {           
            totalDevolucion = subtotal + descuento - impuesto;
        }
    }
}