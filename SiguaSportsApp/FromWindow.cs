using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SiguaSportsApp
{
    public partial class FromWindow : Form
    {
        public FromWindow()
        {
            InitializeComponent();
        }

        private void FromWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SiguaSportsDataSet.Ventas' table. You can move, or remove it, as needed.
            rpc.Add(new ReportParameter("rp_Factura", datos.NumFactura));
            rpc.Add(new ReportParameter("rp_Fecha", datos.FechaTransaccion));
            rpc.Add(new ReportParameter("rp_Empleado", datos.IdVendedor));
            rpc.Add(new ReportParameter("rp_Subtotal", Math.Round(datos.Subtotal, 2).ToString()));
            rpc.Add(new ReportParameter("rp_Descuento", Math.Round(datos.Descuento, 2).ToString()));
            rpc.Add(new ReportParameter("rp_Impuesto", Math.Round(datos.Impuesto, 2).ToString()));
            rpc.Add(new ReportParameter("rp_Total", Math.Round(datos.Total, 2).ToString()));
            this.reportViewer1.LocalReport.SetParameters(rpc);

            this.VentasTableAdapter.Fill(this.SiguaSportsDataSet.Ventas);
            this.reportViewer1.RefreshReport();
        }

        ClassDatosTransaccion datos = new ClassDatosTransaccion();
        ReportParameterCollection rpc = new ReportParameterCollection();

        private void boton_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
