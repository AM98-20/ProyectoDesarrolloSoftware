﻿namespace SiguaSportsApp
{
    partial class FormCambio
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambio));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.contenedor_menu = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_logueo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Administracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Devoluciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Ventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contraer_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tc_Cambio = new System.Windows.Forms.TabControl();
            this.tp_cambio = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgv_ProdCambio = new System.Windows.Forms.DataGridView();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_Factura = new System.Windows.Forms.MaskedTextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgvCambio = new System.Windows.Forms.DataGridView();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtDevolucion = new System.Windows.Forms.TextBox();
            this.lbldevolucion = new System.Windows.Forms.Label();
            this.lblvendedor = new System.Windows.Forms.Label();
            this.txtvendedor = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.lblISV = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tp_historial = new System.Windows.Forms.TabPage();
            this.dgv_Historial = new System.Windows.Forms.DataGridView();
            this.Expandir_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            this.contenedor_menu.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.tc_Cambio.SuspendLayout();
            this.tp_cambio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambio)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tp_historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_maximizar);
            this.panel1.Controls.Add(this.btn_restaurar);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.contraer_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1603, 65);
            this.panel1.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(794, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cambios";
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_maximizar.Image = global::SiguaSportsApp.Properties.Resources.maximize__2_;
            this.btn_maximizar.Location = new System.Drawing.Point(1499, 14);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(40, 37);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 80;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click_1);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.btn_restaurar.Image = global::SiguaSportsApp.Properties.Resources.window_restore;
            this.btn_restaurar.Location = new System.Drawing.Point(1499, 14);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(40, 37);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 81;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.btn_salir.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.btn_salir.Location = new System.Drawing.Point(1547, 14);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 37);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 78;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimizar.Image = global::SiguaSportsApp.Properties.Resources.minus__1_;
            this.btn_minimizar.Location = new System.Drawing.Point(1451, 14);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(40, 37);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 79;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click_1);
            // 
            // contenedor_menu
            // 
            this.contenedor_menu.Controls.Add(this.Sidebar);
            this.contraer_menu.SetDecoration(this.contenedor_menu, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.contenedor_menu, BunifuAnimatorNS.DecorationType.None);
            this.contenedor_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedor_menu.Location = new System.Drawing.Point(0, 65);
            this.contenedor_menu.Margin = new System.Windows.Forms.Padding(4);
            this.contenedor_menu.Name = "contenedor_menu";
            this.contenedor_menu.Size = new System.Drawing.Size(285, 723);
            this.contenedor_menu.TabIndex = 68;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.btn_logueo);
            this.Sidebar.Controls.Add(this.btn_Administracion);
            this.Sidebar.Controls.Add(this.btn_Devoluciones);
            this.Sidebar.Controls.Add(this.btn_Ventas);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox2);
            this.Expandir_menu.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(11)))));
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(272, 723);
            this.Sidebar.TabIndex = 0;
            // 
            // btn_logueo
            // 
            this.btn_logueo.Activecolor = System.Drawing.Color.Transparent;
            this.btn_logueo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logueo.BackColor = System.Drawing.Color.Transparent;
            this.btn_logueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logueo.BorderRadius = 0;
            this.btn_logueo.ButtonText = "             CERRAR SESIÓN";
            this.btn_logueo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contraer_menu.SetDecoration(this.btn_logueo, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_logueo, BunifuAnimatorNS.DecorationType.None);
            this.btn_logueo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_logueo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_logueo.Iconimage = global::SiguaSportsApp.Properties.Resources.logout__1_;
            this.btn_logueo.Iconimage_right = null;
            this.btn_logueo.Iconimage_right_Selected = null;
            this.btn_logueo.Iconimage_Selected = null;
            this.btn_logueo.IconMarginLeft = 0;
            this.btn_logueo.IconMarginRight = 0;
            this.btn_logueo.IconRightVisible = true;
            this.btn_logueo.IconRightZoom = 0D;
            this.btn_logueo.IconVisible = true;
            this.btn_logueo.IconZoom = 85D;
            this.btn_logueo.IsTab = false;
            this.btn_logueo.Location = new System.Drawing.Point(8, 659);
            this.btn_logueo.Margin = new System.Windows.Forms.Padding(5);
            this.btn_logueo.Name = "btn_logueo";
            this.btn_logueo.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_logueo.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_logueo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_logueo.selected = false;
            this.btn_logueo.Size = new System.Drawing.Size(291, 52);
            this.btn_logueo.TabIndex = 10;
            this.btn_logueo.Text = "             CERRAR SESIÓN";
            this.btn_logueo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logueo.Textcolor = System.Drawing.Color.White;
            this.btn_logueo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logueo.Click += new System.EventHandler(this.btn_logueo_Click);
            // 
            // btn_Administracion
            // 
            this.btn_Administracion.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Administracion.BackColor = System.Drawing.Color.Transparent;
            this.btn_Administracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Administracion.BorderRadius = 0;
            this.btn_Administracion.ButtonText = "              ADMINISTRACIÓN";
            this.btn_Administracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contraer_menu.SetDecoration(this.btn_Administracion, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_Administracion, BunifuAnimatorNS.DecorationType.None);
            this.btn_Administracion.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Administracion.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Administracion.Iconimage = global::SiguaSportsApp.Properties.Resources.ceo;
            this.btn_Administracion.Iconimage_right = null;
            this.btn_Administracion.Iconimage_right_Selected = null;
            this.btn_Administracion.Iconimage_Selected = null;
            this.btn_Administracion.IconMarginLeft = 0;
            this.btn_Administracion.IconMarginRight = 0;
            this.btn_Administracion.IconRightVisible = true;
            this.btn_Administracion.IconRightZoom = 0D;
            this.btn_Administracion.IconVisible = true;
            this.btn_Administracion.IconZoom = 85D;
            this.btn_Administracion.IsTab = false;
            this.btn_Administracion.Location = new System.Drawing.Point(8, 242);
            this.btn_Administracion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Administracion.Name = "btn_Administracion";
            this.btn_Administracion.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Administracion.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Administracion.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Administracion.selected = false;
            this.btn_Administracion.Size = new System.Drawing.Size(307, 52);
            this.btn_Administracion.TabIndex = 7;
            this.btn_Administracion.Text = "              ADMINISTRACIÓN";
            this.btn_Administracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Administracion.Textcolor = System.Drawing.Color.White;
            this.btn_Administracion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Administracion.Click += new System.EventHandler(this.btn_Administracion_Click);
            // 
            // btn_Devoluciones
            // 
            this.btn_Devoluciones.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Devoluciones.BackColor = System.Drawing.Color.Transparent;
            this.btn_Devoluciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Devoluciones.BorderRadius = 0;
            this.btn_Devoluciones.ButtonText = "              DEVOLUCIONES";
            this.btn_Devoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contraer_menu.SetDecoration(this.btn_Devoluciones, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_Devoluciones, BunifuAnimatorNS.DecorationType.None);
            this.btn_Devoluciones.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Devoluciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Devoluciones.Iconimage = global::SiguaSportsApp.Properties.Resources.return_on_investment;
            this.btn_Devoluciones.Iconimage_right = null;
            this.btn_Devoluciones.Iconimage_right_Selected = null;
            this.btn_Devoluciones.Iconimage_Selected = null;
            this.btn_Devoluciones.IconMarginLeft = 0;
            this.btn_Devoluciones.IconMarginRight = 0;
            this.btn_Devoluciones.IconRightVisible = true;
            this.btn_Devoluciones.IconRightZoom = 0D;
            this.btn_Devoluciones.IconVisible = true;
            this.btn_Devoluciones.IconZoom = 85D;
            this.btn_Devoluciones.IsTab = false;
            this.btn_Devoluciones.Location = new System.Drawing.Point(8, 158);
            this.btn_Devoluciones.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Devoluciones.Name = "btn_Devoluciones";
            this.btn_Devoluciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Devoluciones.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Devoluciones.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Devoluciones.selected = false;
            this.btn_Devoluciones.Size = new System.Drawing.Size(284, 52);
            this.btn_Devoluciones.TabIndex = 4;
            this.btn_Devoluciones.Text = "              DEVOLUCIONES";
            this.btn_Devoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Devoluciones.Textcolor = System.Drawing.Color.White;
            this.btn_Devoluciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Devoluciones.Click += new System.EventHandler(this.btn_Devoluciones_Click);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ventas.BorderRadius = 0;
            this.btn_Ventas.ButtonText = "              VENTAS";
            this.btn_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contraer_menu.SetDecoration(this.btn_Ventas, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_Ventas, BunifuAnimatorNS.DecorationType.None);
            this.btn_Ventas.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Ventas.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Ventas.Iconimage = global::SiguaSportsApp.Properties.Resources.sales;
            this.btn_Ventas.Iconimage_right = null;
            this.btn_Ventas.Iconimage_right_Selected = null;
            this.btn_Ventas.Iconimage_Selected = null;
            this.btn_Ventas.IconMarginLeft = 0;
            this.btn_Ventas.IconMarginRight = 0;
            this.btn_Ventas.IconRightVisible = true;
            this.btn_Ventas.IconRightZoom = 0D;
            this.btn_Ventas.IconVisible = true;
            this.btn_Ventas.IconZoom = 85D;
            this.btn_Ventas.IsTab = false;
            this.btn_Ventas.Location = new System.Drawing.Point(8, 79);
            this.btn_Ventas.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Ventas.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Ventas.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Ventas.selected = false;
            this.btn_Ventas.Size = new System.Drawing.Size(235, 52);
            this.btn_Ventas.TabIndex = 3;
            this.btn_Ventas.Text = "              VENTAS";
            this.btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ventas.Textcolor = System.Drawing.Color.White;
            this.btn_Ventas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.contraer_menu.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(4, 49);
            this.LineaSidebar.Margin = new System.Windows.Forms.Padding(5);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(264, 12);
            this.LineaSidebar.TabIndex = 2;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.Expandir_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "SiguaSport";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::SiguaSportsApp.Properties.Resources._869bc446_c29f_4183_8a33_8393fdb17213;
            this.pictureBox2.Location = new System.Drawing.Point(12, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_menu
            // 
            this.contraer_menu.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_menu.Image = global::SiguaSportsApp.Properties.Resources.menu;
            this.btn_menu.Location = new System.Drawing.Point(31, 14);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(40, 37);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_menu.TabIndex = 70;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 71;
            this.label1.Text = "MENÚ";
            // 
            // radio
            // 
            this.radio.ElipseRadius = 5;
            this.radio.TargetControl = this.Sidebar;
            // 
            // contraer_menu
            // 
            this.contraer_menu.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.contraer_menu.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.contraer_menu.DefaultAnimation = animation3;
            // 
            // tc_Cambio
            // 
            this.tc_Cambio.Controls.Add(this.tp_cambio);
            this.tc_Cambio.Controls.Add(this.tp_historial);
            this.contraer_menu.SetDecoration(this.tc_Cambio, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.tc_Cambio, BunifuAnimatorNS.DecorationType.None);
            this.tc_Cambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Cambio.Location = new System.Drawing.Point(285, 65);
            this.tc_Cambio.Name = "tc_Cambio";
            this.tc_Cambio.SelectedIndex = 0;
            this.tc_Cambio.Size = new System.Drawing.Size(1318, 723);
            this.tc_Cambio.TabIndex = 72;
            // 
            // tp_cambio
            // 
            this.tp_cambio.Controls.Add(this.btnAgregar);
            this.tp_cambio.Controls.Add(this.dgv_ProdCambio);
            this.tp_cambio.Controls.Add(this.nud_Cantidad);
            this.tp_cambio.Controls.Add(this.label3);
            this.tp_cambio.Controls.Add(this.mtb_Factura);
            this.tp_cambio.Controls.Add(this.lblFactura);
            this.tp_cambio.Controls.Add(this.btn_Buscar);
            this.tp_cambio.Controls.Add(this.dgvCambio);
            this.tp_cambio.Controls.Add(this.txtMotivo);
            this.tp_cambio.Controls.Add(this.lblMotivo);
            this.tp_cambio.Controls.Add(this.panel2);
            this.tp_cambio.Controls.Add(this.panel4);
            this.Expandir_menu.SetDecoration(this.tp_cambio, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.tp_cambio, BunifuAnimatorNS.DecorationType.None);
            this.tp_cambio.Location = new System.Drawing.Point(4, 25);
            this.tp_cambio.Name = "tp_cambio";
            this.tp_cambio.Padding = new System.Windows.Forms.Padding(3);
            this.tp_cambio.Size = new System.Drawing.Size(1310, 694);
            this.tp_cambio.TabIndex = 0;
            this.tp_cambio.Text = "Cambio";
            this.tp_cambio.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Expandir_menu.SetDecoration(this.btnAgregar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btnAgregar, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregar.Location = new System.Drawing.Point(1116, 168);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 29);
            this.btnAgregar.TabIndex = 90;
            this.btnAgregar.Text = "Agregar Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgv_ProdCambio
            // 
            this.dgv_ProdCambio.AllowUserToAddRows = false;
            this.dgv_ProdCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ProdCambio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProdCambio.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ProdCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProdCambio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaCantidad,
            this.columnaMotivo,
            this.columnaCambio});
            this.Expandir_menu.SetDecoration(this.dgv_ProdCambio, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dgv_ProdCambio, BunifuAnimatorNS.DecorationType.None);
            this.dgv_ProdCambio.Enabled = false;
            this.dgv_ProdCambio.GridColor = System.Drawing.Color.White;
            this.dgv_ProdCambio.Location = new System.Drawing.Point(3, 214);
            this.dgv_ProdCambio.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ProdCambio.Name = "dgv_ProdCambio";
            this.dgv_ProdCambio.ReadOnly = true;
            this.dgv_ProdCambio.RowHeadersVisible = false;
            this.dgv_ProdCambio.RowHeadersWidth = 51;
            this.dgv_ProdCambio.Size = new System.Drawing.Size(1298, 334);
            this.dgv_ProdCambio.TabIndex = 89;
            this.dgv_ProdCambio.Visible = false;
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.HeaderText = "Producto";
            this.columnaCodigo.MinimumWidth = 6;
            this.columnaCodigo.Name = "columnaCodigo";
            this.columnaCodigo.ReadOnly = true;
            // 
            // columnaCantidad
            // 
            this.columnaCantidad.HeaderText = "Cantidad";
            this.columnaCantidad.MinimumWidth = 6;
            this.columnaCantidad.Name = "columnaCantidad";
            this.columnaCantidad.ReadOnly = true;
            // 
            // columnaMotivo
            // 
            this.columnaMotivo.HeaderText = "Motivo";
            this.columnaMotivo.MinimumWidth = 6;
            this.columnaMotivo.Name = "columnaMotivo";
            this.columnaMotivo.ReadOnly = true;
            // 
            // columnaCambio
            // 
            this.columnaCambio.HeaderText = "Cambio";
            this.columnaCambio.MinimumWidth = 6;
            this.columnaCambio.Name = "columnaCambio";
            this.columnaCambio.ReadOnly = true;
            // 
            // nud_Cantidad
            // 
            this.contraer_menu.SetDecoration(this.nud_Cantidad, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.nud_Cantidad, BunifuAnimatorNS.DecorationType.None);
            this.nud_Cantidad.Enabled = false;
            this.nud_Cantidad.Location = new System.Drawing.Point(132, 130);
            this.nud_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(51, 22);
            this.nud_Cantidad.TabIndex = 88;
            this.nud_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 87;
            this.label3.Text = "Cántidad";
            // 
            // mtb_Factura
            // 
            this.contraer_menu.SetDecoration(this.mtb_Factura, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.mtb_Factura, BunifuAnimatorNS.DecorationType.None);
            this.mtb_Factura.Location = new System.Drawing.Point(133, 81);
            this.mtb_Factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtb_Factura.Mask = "000-000-00-0000000";
            this.mtb_Factura.Name = "mtb_Factura";
            this.mtb_Factura.Size = new System.Drawing.Size(157, 22);
            this.mtb_Factura.TabIndex = 86;
            // 
            // lblFactura
            // 
            this.lblFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFactura.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblFactura, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblFactura, BunifuAnimatorNS.DecorationType.None);
            this.lblFactura.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(21, 79);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(105, 24);
            this.lblFactura.TabIndex = 85;
            this.lblFactura.Text = "No. Factura";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Expandir_menu.SetDecoration(this.btn_Buscar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_Buscar, BunifuAnimatorNS.DecorationType.None);
            this.btn_Buscar.Location = new System.Drawing.Point(510, 77);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(88, 29);
            this.btn_Buscar.TabIndex = 83;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click_1);
            // 
            // dgvCambio
            // 
            this.dgvCambio.AllowUserToAddRows = false;
            this.dgvCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCambio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCambio.BackgroundColor = System.Drawing.Color.White;
            this.dgvCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Expandir_menu.SetDecoration(this.dgvCambio, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dgvCambio, BunifuAnimatorNS.DecorationType.None);
            this.dgvCambio.Enabled = false;
            this.dgvCambio.GridColor = System.Drawing.Color.White;
            this.dgvCambio.Location = new System.Drawing.Point(4, 214);
            this.dgvCambio.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCambio.Name = "dgvCambio";
            this.dgvCambio.ReadOnly = true;
            this.dgvCambio.RowHeadersVisible = false;
            this.dgvCambio.RowHeadersWidth = 51;
            this.dgvCambio.Size = new System.Drawing.Size(1298, 334);
            this.dgvCambio.TabIndex = 82;
            this.dgvCambio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCambio_CellContentClick_1);
            this.dgvCambio.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCambio_CellContentClick);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contraer_menu.SetDecoration(this.txtMotivo, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtMotivo, BunifuAnimatorNS.DecorationType.None);
            this.txtMotivo.Location = new System.Drawing.Point(132, 175);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(354, 22);
            this.txtMotivo.TabIndex = 81;
            // 
            // lblMotivo
            // 
            this.lblMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMotivo.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblMotivo, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblMotivo, BunifuAnimatorNS.DecorationType.None);
            this.lblMotivo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(21, 173);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(65, 24);
            this.lblMotivo.TabIndex = 80;
            this.lblMotivo.Text = "Motivo";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtp_Fecha);
            this.panel2.Controls.Add(this.lblfecha);
            this.panel2.Controls.Add(this.txtDevolucion);
            this.panel2.Controls.Add(this.lbldevolucion);
            this.panel2.Controls.Add(this.lblvendedor);
            this.panel2.Controls.Add(this.txtvendedor);
            this.contraer_menu.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 57);
            this.panel2.TabIndex = 78;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.dtp_Fecha, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.dtp_Fecha, BunifuAnimatorNS.DecorationType.None);
            this.dtp_Fecha.Enabled = false;
            this.dtp_Fecha.Location = new System.Drawing.Point(1025, 16);
            this.dtp_Fecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(265, 22);
            this.dtp_Fecha.TabIndex = 2;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblfecha, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblfecha, BunifuAnimatorNS.DecorationType.None);
            this.lblfecha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(959, 14);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(57, 24);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha";
            // 
            // txtDevolucion
            // 
            this.txtDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDevolucion.BackColor = System.Drawing.Color.White;
            this.txtDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraer_menu.SetDecoration(this.txtDevolucion, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtDevolucion, BunifuAnimatorNS.DecorationType.None);
            this.txtDevolucion.Enabled = false;
            this.txtDevolucion.Location = new System.Drawing.Point(199, 16);
            this.txtDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDevolucion.Name = "txtDevolucion";
            this.txtDevolucion.Size = new System.Drawing.Size(177, 22);
            this.txtDevolucion.TabIndex = 2;
            // 
            // lbldevolucion
            // 
            this.lbldevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbldevolucion.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lbldevolucion, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lbldevolucion, BunifuAnimatorNS.DecorationType.None);
            this.lbldevolucion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldevolucion.Location = new System.Drawing.Point(29, 16);
            this.lbldevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldevolucion.Name = "lbldevolucion";
            this.lbldevolucion.Size = new System.Drawing.Size(161, 24);
            this.lbldevolucion.TabIndex = 2;
            this.lbldevolucion.Text = "No. De Devolución:";
            // 
            // lblvendedor
            // 
            this.lblvendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblvendedor.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblvendedor, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblvendedor, BunifuAnimatorNS.DecorationType.None);
            this.lblvendedor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvendedor.Location = new System.Drawing.Point(408, 16);
            this.lblvendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvendedor.Name = "lblvendedor";
            this.lblvendedor.Size = new System.Drawing.Size(88, 24);
            this.lblvendedor.TabIndex = 53;
            this.lblvendedor.Text = "Vendedor";
            // 
            // txtvendedor
            // 
            this.txtvendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtvendedor.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.txtvendedor, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtvendedor, BunifuAnimatorNS.DecorationType.None);
            this.txtvendedor.Enabled = false;
            this.txtvendedor.Location = new System.Drawing.Point(514, 15);
            this.txtvendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtvendedor.Name = "txtvendedor";
            this.txtvendedor.Size = new System.Drawing.Size(411, 22);
            this.txtvendedor.TabIndex = 52;
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnConfirmar);
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.txtDes);
            this.panel4.Controls.Add(this.lblDes);
            this.panel4.Controls.Add(this.lblSub);
            this.panel4.Controls.Add(this.txtSub);
            this.panel4.Controls.Add(this.txtISV);
            this.panel4.Controls.Add(this.lblISV);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.txtTotal);
            this.contraer_menu.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 550);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1304, 141);
            this.panel4.TabIndex = 79;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Expandir_menu.SetDecoration(this.btnConfirmar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btnConfirmar, BunifuAnimatorNS.DecorationType.None);
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnConfirmar.Location = new System.Drawing.Point(1167, 73);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 28);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Expandir_menu.SetDecoration(this.btnCancelar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btnCancelar, BunifuAnimatorNS.DecorationType.None);
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnCancelar.Location = new System.Drawing.Point(1167, 36);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // txtDes
            // 
            this.txtDes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDes.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.txtDes, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtDes, BunifuAnimatorNS.DecorationType.None);
            this.txtDes.Enabled = false;
            this.txtDes.Location = new System.Drawing.Point(907, 42);
            this.txtDes.Margin = new System.Windows.Forms.Padding(4);
            this.txtDes.Name = "txtDes";
            this.txtDes.ReadOnly = true;
            this.txtDes.Size = new System.Drawing.Size(132, 22);
            this.txtDes.TabIndex = 10;
            this.txtDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDes
            // 
            this.lblDes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDes.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblDes, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblDes, BunifuAnimatorNS.DecorationType.None);
            this.lblDes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(783, 40);
            this.lblDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(95, 24);
            this.lblDes.TabIndex = 9;
            this.lblDes.Text = "Descuento";
            // 
            // lblSub
            // 
            this.lblSub.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSub.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblSub, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblSub, BunifuAnimatorNS.DecorationType.None);
            this.lblSub.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(796, 10);
            this.lblSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(81, 24);
            this.lblSub.TabIndex = 8;
            this.lblSub.Text = "Subtotal";
            // 
            // txtSub
            // 
            this.txtSub.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSub.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.txtSub, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtSub, BunifuAnimatorNS.DecorationType.None);
            this.txtSub.Enabled = false;
            this.txtSub.Location = new System.Drawing.Point(907, 11);
            this.txtSub.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub.Name = "txtSub";
            this.txtSub.ReadOnly = true;
            this.txtSub.Size = new System.Drawing.Size(132, 22);
            this.txtSub.TabIndex = 7;
            this.txtSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtISV
            // 
            this.txtISV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtISV.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.txtISV, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtISV, BunifuAnimatorNS.DecorationType.None);
            this.txtISV.Enabled = false;
            this.txtISV.Location = new System.Drawing.Point(907, 73);
            this.txtISV.Margin = new System.Windows.Forms.Padding(4);
            this.txtISV.Name = "txtISV";
            this.txtISV.ReadOnly = true;
            this.txtISV.Size = new System.Drawing.Size(132, 22);
            this.txtISV.TabIndex = 6;
            this.txtISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblISV
            // 
            this.lblISV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblISV.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblISV, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblISV, BunifuAnimatorNS.DecorationType.None);
            this.lblISV.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISV.Location = new System.Drawing.Point(835, 73);
            this.lblISV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(42, 24);
            this.lblISV.TabIndex = 5;
            this.lblISV.Text = "ISV";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblTotal, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblTotal, BunifuAnimatorNS.DecorationType.None);
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(823, 107);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 24);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.txtTotal, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtTotal, BunifuAnimatorNS.DecorationType.None);
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(907, 109);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tp_historial
            // 
            this.tp_historial.Controls.Add(this.dgv_Historial);
            this.Expandir_menu.SetDecoration(this.tp_historial, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.tp_historial, BunifuAnimatorNS.DecorationType.None);
            this.tp_historial.Location = new System.Drawing.Point(4, 25);
            this.tp_historial.Name = "tp_historial";
            this.tp_historial.Padding = new System.Windows.Forms.Padding(3);
            this.tp_historial.Size = new System.Drawing.Size(1310, 694);
            this.tp_historial.TabIndex = 1;
            this.tp_historial.Text = "Historial";
            this.tp_historial.UseVisualStyleBackColor = true;
            // 
            // dgv_Historial
            // 
            this.dgv_Historial.AllowUserToAddRows = false;
            this.dgv_Historial.AllowUserToDeleteRows = false;
            this.dgv_Historial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Historial.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Expandir_menu.SetDecoration(this.dgv_Historial, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dgv_Historial, BunifuAnimatorNS.DecorationType.None);
            this.dgv_Historial.Enabled = false;
            this.dgv_Historial.Location = new System.Drawing.Point(6, 15);
            this.dgv_Historial.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Historial.Name = "dgv_Historial";
            this.dgv_Historial.ReadOnly = true;
            this.dgv_Historial.RowHeadersVisible = false;
            this.dgv_Historial.RowHeadersWidth = 51;
            this.dgv_Historial.Size = new System.Drawing.Size(1294, 659);
            this.dgv_Historial.TabIndex = 62;
            // 
            // Expandir_menu
            // 
            this.Expandir_menu.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Expandir_menu.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.Expandir_menu.DefaultAnimation = animation4;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 788);
            this.Controls.Add(this.tc_Cambio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.contenedor_menu);
            this.Controls.Add(this.panel1);
            this.Expandir_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromCambio";
            this.Load += new System.EventHandler(this.FormCambio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            this.contenedor_menu.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.tc_Cambio.ResumeLayout(false);
            this.tp_cambio.ResumeLayout(false);
            this.tp_cambio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tp_historial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel contenedor_menu;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Ventas;
        private Bunifu.Framework.UI.BunifuFlatButton btn_logueo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Administracion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Devoluciones;
        private BunifuAnimatorNS.BunifuTransition contraer_menu;
        private BunifuAnimatorNS.BunifuTransition Expandir_menu;
        private Bunifu.Framework.UI.BunifuElipse radio;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tc_Cambio;
        private System.Windows.Forms.TabPage tp_cambio;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_Factura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dgvCambio;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox txtDevolucion;
        private System.Windows.Forms.Label lbldevolucion;
        private System.Windows.Forms.Label lblvendedor;
        private System.Windows.Forms.TextBox txtvendedor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TabPage tp_historial;
        private System.Windows.Forms.DataGridView dgv_Historial;
        private System.Windows.Forms.DataGridView dgv_ProdCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCambio;
        private System.Windows.Forms.Button btnAgregar;
    }
}