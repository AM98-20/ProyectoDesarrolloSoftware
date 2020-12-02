
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SiguaSportsDataSet = new SiguaSportsApp.SiguaSportsDataSet();
            this.VentasTableAdapter = new SiguaSportsApp.SiguaSportsDataSetTableAdapters.VentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiguaSportsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReceiptData";
            reportDataSource1.Value = this.VentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SiguaSportsApp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(552, 524);
            this.reportViewer1.TabIndex = 0;
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
            // VentasTableAdapter
            // 
            this.VentasTableAdapter.ClearBeforeFill = true;
            // 
            // FromWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 524);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "FromWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromWindow";
            this.Load += new System.EventHandler(this.FromWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiguaSportsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VentasBindingSource;
        private SiguaSportsDataSet SiguaSportsDataSet;
        private SiguaSportsDataSetTableAdapters.VentasTableAdapter VentasTableAdapter;
    }
}