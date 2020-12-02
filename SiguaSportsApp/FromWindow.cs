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
            this.VentasTableAdapter.Fill(this.SiguaSportsDataSet.Ventas);

            this.reportViewer1.RefreshReport();
        }
    }
}
