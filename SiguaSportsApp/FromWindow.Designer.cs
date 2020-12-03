
namespace SiguaSportsApp
{
    partial class FromWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SiguaSportsDataSet = new SiguaSportsApp.SiguaSportsDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VentasTableAdapter = new SiguaSportsApp.SiguaSportsDataSetTableAdapters.VentasTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boton_salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiguaSportsDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boton_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // VentasBindingSource
            // 
            this.VentasBindingSource.DataMember = "Ventas";
            this.VentasBindingSource.DataSource = this.SiguaSportsDataSet;
            // 
            // SiguaSportsDataSet
            // 
            this.SiguaSportsDataSet.DataSetName = "SiguaSportsDataSet";
            this.SiguaSportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReceiptData";
            reportDataSource1.Value = this.VentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SiguaSportsApp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 29);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(544, 547);
            this.reportViewer1.TabIndex = 0;
            // 
            // VentasTableAdapter
            // 
            this.VentasTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boton_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 28);
            this.panel1.TabIndex = 1;
            // 
            // boton_salir
            // 
            this.boton_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_salir.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.boton_salir.Location = new System.Drawing.Point(506, 0);
            this.boton_salir.Margin = new System.Windows.Forms.Padding(4);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(34, 28);
            this.boton_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_salir.TabIndex = 42;
            this.boton_salir.TabStop = false;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // FromWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 576);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "FromWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromWindow";
            this.Load += new System.EventHandler(this.FromWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiguaSportsDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boton_salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VentasBindingSource;
        private SiguaSportsDataSet SiguaSportsDataSet;
        private SiguaSportsDataSetTableAdapters.VentasTableAdapter VentasTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox boton_salir;
    }
}