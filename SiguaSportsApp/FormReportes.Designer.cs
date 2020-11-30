namespace SiguaSportsApp
{
    partial class FormReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.boton_max = new System.Windows.Forms.PictureBox();
            this.boton_min = new System.Windows.Forms.PictureBox();
            this.boton_cerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.contenedor_menu = new System.Windows.Forms.Panel();
            this.SideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Registro_bodega = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_logueo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Inventario_bodega = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.linea_sidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contraer_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.boton_restaurar = new System.Windows.Forms.PictureBox();
            this.expandir_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.radio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tc_Reportes = new System.Windows.Forms.TabControl();
            this.tp_Mensual = new System.Windows.Forms.TabPage();
            this.tp_Diario = new System.Windows.Forms.TabPage();
            this.dgvReporteFinanciero = new System.Windows.Forms.DataGridView();
            this.bnt_Buscar = new System.Windows.Forms.Button();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ReporteDiario = new System.Windows.Forms.DataGridView();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boton_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.contenedor_menu.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_restaurar)).BeginInit();
            this.tc_Reportes.SuspendLayout();
            this.tp_Mensual.SuspendLayout();
            this.tp_Diario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteFinanciero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReporteDiario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btnRegresar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btnRegresar, BunifuAnimatorNS.DecorationType.None);
            this.btnRegresar.Location = new System.Drawing.Point(2036, 775);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 28);
            this.btnRegresar.TabIndex = 40;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.boton_max);
            this.panel1.Controls.Add(this.boton_min);
            this.panel1.Controls.Add(this.boton_cerrar);
            this.panel1.Controls.Add(this.btnRestaurar);
            this.expandir_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1587, 65);
            this.panel1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.contraer_menu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(763, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Reportes";
            // 
            // boton_max
            // 
            this.boton_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.boton_max, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.boton_max, BunifuAnimatorNS.DecorationType.None);
            this.boton_max.Image = global::SiguaSportsApp.Properties.Resources.maximize__2_;
            this.boton_max.Location = new System.Drawing.Point(1456, 14);
            this.boton_max.Margin = new System.Windows.Forms.Padding(4);
            this.boton_max.Name = "boton_max";
            this.boton_max.Size = new System.Drawing.Size(40, 37);
            this.boton_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_max.TabIndex = 51;
            this.boton_max.TabStop = false;
            this.boton_max.Click += new System.EventHandler(this.boton_max_Click);
            // 
            // boton_min
            // 
            this.boton_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.boton_min, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.boton_min, BunifuAnimatorNS.DecorationType.None);
            this.boton_min.Image = global::SiguaSportsApp.Properties.Resources.minus__1_;
            this.boton_min.Location = new System.Drawing.Point(1409, 14);
            this.boton_min.Margin = new System.Windows.Forms.Padding(4);
            this.boton_min.Name = "boton_min";
            this.boton_min.Size = new System.Drawing.Size(40, 37);
            this.boton_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_min.TabIndex = 50;
            this.boton_min.TabStop = false;
            this.boton_min.Click += new System.EventHandler(this.boton_min_Click);
            // 
            // boton_cerrar
            // 
            this.boton_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.boton_cerrar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.boton_cerrar, BunifuAnimatorNS.DecorationType.None);
            this.boton_cerrar.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.boton_cerrar.Location = new System.Drawing.Point(1505, 14);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(40, 37);
            this.boton_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerrar.TabIndex = 49;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Click += new System.EventHandler(this.boton_cerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.btnRestaurar.Image = global::SiguaSportsApp.Properties.Resources.window_restore;
            this.btnRestaurar.Location = new System.Drawing.Point(1457, 15);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 37);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 52;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // contenedor_menu
            // 
            this.contenedor_menu.Controls.Add(this.SideBar);
            this.expandir_menu.SetDecoration(this.contenedor_menu, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.contenedor_menu, BunifuAnimatorNS.DecorationType.None);
            this.contenedor_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedor_menu.Location = new System.Drawing.Point(0, 65);
            this.contenedor_menu.Margin = new System.Windows.Forms.Padding(4);
            this.contenedor_menu.Name = "contenedor_menu";
            this.contenedor_menu.Size = new System.Drawing.Size(296, 723);
            this.contenedor_menu.TabIndex = 42;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.btn_Registro_bodega);
            this.SideBar.Controls.Add(this.btn_logueo);
            this.SideBar.Controls.Add(this.btn_Inventario_bodega);
            this.SideBar.Controls.Add(this.label3);
            this.SideBar.Controls.Add(this.linea_sidebar);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.expandir_menu.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.SideBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(11)))));
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(4);
            this.SideBar.Name = "SideBar";
            this.SideBar.Quality = 10;
            this.SideBar.Size = new System.Drawing.Size(272, 723);
            this.SideBar.TabIndex = 0;
            // 
            // btn_Registro_bodega
            // 
            this.btn_Registro_bodega.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Registro_bodega.BackColor = System.Drawing.Color.Transparent;
            this.btn_Registro_bodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Registro_bodega.BorderRadius = 0;
            this.btn_Registro_bodega.ButtonText = "              REGISTRO - BODEGA";
            this.btn_Registro_bodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contraer_menu.SetDecoration(this.btn_Registro_bodega, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_Registro_bodega, BunifuAnimatorNS.DecorationType.None);
            this.btn_Registro_bodega.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Registro_bodega.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Registro_bodega.Iconimage = global::SiguaSportsApp.Properties.Resources.files;
            this.btn_Registro_bodega.Iconimage_right = null;
            this.btn_Registro_bodega.Iconimage_right_Selected = null;
            this.btn_Registro_bodega.Iconimage_Selected = null;
            this.btn_Registro_bodega.IconMarginLeft = 0;
            this.btn_Registro_bodega.IconMarginRight = 0;
            this.btn_Registro_bodega.IconRightVisible = true;
            this.btn_Registro_bodega.IconRightZoom = 0D;
            this.btn_Registro_bodega.IconVisible = true;
            this.btn_Registro_bodega.IconZoom = 85D;
            this.btn_Registro_bodega.IsTab = false;
            this.btn_Registro_bodega.Location = new System.Drawing.Point(8, 150);
            this.btn_Registro_bodega.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Registro_bodega.Name = "btn_Registro_bodega";
            this.btn_Registro_bodega.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Registro_bodega.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Registro_bodega.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Registro_bodega.selected = false;
            this.btn_Registro_bodega.Size = new System.Drawing.Size(381, 52);
            this.btn_Registro_bodega.TabIndex = 10;
            this.btn_Registro_bodega.Text = "              REGISTRO - BODEGA";
            this.btn_Registro_bodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registro_bodega.Textcolor = System.Drawing.Color.White;
            this.btn_Registro_bodega.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registro_bodega.Click += new System.EventHandler(this.btn_Registro_bodega_Click);
            // 
            // btn_logueo
            // 
            this.btn_logueo.Activecolor = System.Drawing.Color.Transparent;
            this.btn_logueo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logueo.BackColor = System.Drawing.Color.Transparent;
            this.btn_logueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logueo.BorderRadius = 0;
            this.btn_logueo.ButtonText = "              CERRAR SESIÓN";
            this.btn_logueo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contraer_menu.SetDecoration(this.btn_logueo, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_logueo, BunifuAnimatorNS.DecorationType.None);
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
            this.btn_logueo.Size = new System.Drawing.Size(309, 52);
            this.btn_logueo.TabIndex = 8;
            this.btn_logueo.Text = "              CERRAR SESIÓN";
            this.btn_logueo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logueo.Textcolor = System.Drawing.Color.White;
            this.btn_logueo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logueo.Click += new System.EventHandler(this.btn_logueo_Click);
            // 
            // btn_Inventario_bodega
            // 
            this.btn_Inventario_bodega.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Inventario_bodega.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inventario_bodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Inventario_bodega.BorderRadius = 0;
            this.btn_Inventario_bodega.ButtonText = "              INVENTARIO-BODEGA";
            this.btn_Inventario_bodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contraer_menu.SetDecoration(this.btn_Inventario_bodega, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_Inventario_bodega, BunifuAnimatorNS.DecorationType.None);
            this.btn_Inventario_bodega.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Inventario_bodega.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Inventario_bodega.Iconimage = global::SiguaSportsApp.Properties.Resources.shelf;
            this.btn_Inventario_bodega.Iconimage_right = null;
            this.btn_Inventario_bodega.Iconimage_right_Selected = null;
            this.btn_Inventario_bodega.Iconimage_Selected = null;
            this.btn_Inventario_bodega.IconMarginLeft = 0;
            this.btn_Inventario_bodega.IconMarginRight = 0;
            this.btn_Inventario_bodega.IconRightVisible = true;
            this.btn_Inventario_bodega.IconRightZoom = 0D;
            this.btn_Inventario_bodega.IconVisible = true;
            this.btn_Inventario_bodega.IconZoom = 85D;
            this.btn_Inventario_bodega.IsTab = false;
            this.btn_Inventario_bodega.Location = new System.Drawing.Point(8, 63);
            this.btn_Inventario_bodega.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Inventario_bodega.Name = "btn_Inventario_bodega";
            this.btn_Inventario_bodega.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Inventario_bodega.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Inventario_bodega.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Inventario_bodega.selected = false;
            this.btn_Inventario_bodega.Size = new System.Drawing.Size(392, 52);
            this.btn_Inventario_bodega.TabIndex = 5;
            this.btn_Inventario_bodega.Text = "              INVENTARIO-BODEGA";
            this.btn_Inventario_bodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventario_bodega.Textcolor = System.Drawing.Color.White;
            this.btn_Inventario_bodega.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventario_bodega.Click += new System.EventHandler(this.btn_Inventario_bodega_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.contraer_menu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "SiguaSport";
            // 
            // linea_sidebar
            // 
            this.linea_sidebar.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.linea_sidebar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.linea_sidebar, BunifuAnimatorNS.DecorationType.None);
            this.linea_sidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linea_sidebar.LineThickness = 1;
            this.linea_sidebar.Location = new System.Drawing.Point(4, 49);
            this.linea_sidebar.Margin = new System.Windows.Forms.Padding(5);
            this.linea_sidebar.Name = "linea_sidebar";
            this.linea_sidebar.Size = new System.Drawing.Size(264, 12);
            this.linea_sidebar.TabIndex = 1;
            this.linea_sidebar.Transparency = 255;
            this.linea_sidebar.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::SiguaSportsApp.Properties.Resources._869bc446_c29f_4183_8a33_8393fdb17213;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // btn_menu
            // 
            this.contraer_menu.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_menu.Image = global::SiguaSportsApp.Properties.Resources.menu;
            this.btn_menu.Location = new System.Drawing.Point(31, 14);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(40, 37);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menu.TabIndex = 43;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.btn_salir.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.btn_salir.Location = new System.Drawing.Point(1957, 14);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 37);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 44;
            this.btn_salir.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.contraer_menu.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "MENÚ";
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.btn_restaurar.Image = global::SiguaSportsApp.Properties.Resources.window_restore;
            this.btn_restaurar.Location = new System.Drawing.Point(1909, 14);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(40, 37);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 46;
            this.btn_restaurar.TabStop = false;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimizar.Image = global::SiguaSportsApp.Properties.Resources.minus__1_;
            this.btn_minimizar.Location = new System.Drawing.Point(1861, 14);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(40, 37);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 47;
            this.btn_minimizar.TabStop = false;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_maximizar.Image = global::SiguaSportsApp.Properties.Resources.maximize__2_;
            this.btn_maximizar.Location = new System.Drawing.Point(1909, 14);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(40, 37);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 48;
            this.btn_maximizar.TabStop = false;
            // 
            // boton_restaurar
            // 
            this.boton_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.boton_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.boton_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.boton_restaurar.Image = global::SiguaSportsApp.Properties.Resources.window_restore;
            this.boton_restaurar.Location = new System.Drawing.Point(1696, 15);
            this.boton_restaurar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_restaurar.Name = "boton_restaurar";
            this.boton_restaurar.Size = new System.Drawing.Size(40, 37);
            this.boton_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_restaurar.TabIndex = 52;
            this.boton_restaurar.TabStop = false;
            this.boton_restaurar.Click += new System.EventHandler(this.boton_restaurar_Click);
            // 
            // expandir_menu
            // 
            this.expandir_menu.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.expandir_menu.Cursor = null;
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
            this.expandir_menu.DefaultAnimation = animation4;
            // 
            // radio
            // 
            this.radio.ElipseRadius = 5;
            this.radio.TargetControl = this.SideBar;
            // 
            // tc_Reportes
            // 
            this.tc_Reportes.Controls.Add(this.tp_Diario);
            this.tc_Reportes.Controls.Add(this.tp_Mensual);
            this.expandir_menu.SetDecoration(this.tc_Reportes, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.tc_Reportes, BunifuAnimatorNS.DecorationType.None);
            this.tc_Reportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Reportes.Location = new System.Drawing.Point(296, 65);
            this.tc_Reportes.Name = "tc_Reportes";
            this.tc_Reportes.SelectedIndex = 0;
            this.tc_Reportes.Size = new System.Drawing.Size(1291, 723);
            this.tc_Reportes.TabIndex = 53;
            // 
            // tp_Mensual
            // 
            this.tp_Mensual.Controls.Add(this.label6);
            this.tp_Mensual.Controls.Add(this.dgvReporteFinanciero);
            this.tp_Mensual.Controls.Add(this.bnt_Buscar);
            this.tp_Mensual.Controls.Add(this.dtpFecha2);
            this.tp_Mensual.Controls.Add(this.dtpFecha1);
            this.tp_Mensual.Controls.Add(this.label2);
            this.tp_Mensual.Controls.Add(this.label1);
            this.expandir_menu.SetDecoration(this.tp_Mensual, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.tp_Mensual, BunifuAnimatorNS.DecorationType.None);
            this.tp_Mensual.Location = new System.Drawing.Point(4, 25);
            this.tp_Mensual.Name = "tp_Mensual";
            this.tp_Mensual.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Mensual.Size = new System.Drawing.Size(1283, 694);
            this.tp_Mensual.TabIndex = 0;
            this.tp_Mensual.Text = "Reporte Mensual";
            this.tp_Mensual.UseVisualStyleBackColor = true;
            // 
            // tp_Diario
            // 
            this.tp_Diario.Controls.Add(this.lbl_Titulo);
            this.tp_Diario.Controls.Add(this.dgv_ReporteDiario);
            this.expandir_menu.SetDecoration(this.tp_Diario, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.tp_Diario, BunifuAnimatorNS.DecorationType.None);
            this.tp_Diario.Location = new System.Drawing.Point(4, 25);
            this.tp_Diario.Name = "tp_Diario";
            this.tp_Diario.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Diario.Size = new System.Drawing.Size(1283, 694);
            this.tp_Diario.TabIndex = 1;
            this.tp_Diario.Text = "Reporte Diario";
            this.tp_Diario.UseVisualStyleBackColor = true;
            // 
            // dgvReporteFinanciero
            // 
            this.dgvReporteFinanciero.AllowUserToAddRows = false;
            this.dgvReporteFinanciero.AllowUserToDeleteRows = false;
            this.dgvReporteFinanciero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporteFinanciero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteFinanciero.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteFinanciero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expandir_menu.SetDecoration(this.dgvReporteFinanciero, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dgvReporteFinanciero, BunifuAnimatorNS.DecorationType.None);
            this.dgvReporteFinanciero.Enabled = false;
            this.dgvReporteFinanciero.Location = new System.Drawing.Point(4, 95);
            this.dgvReporteFinanciero.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteFinanciero.Name = "dgvReporteFinanciero";
            this.dgvReporteFinanciero.ReadOnly = true;
            this.dgvReporteFinanciero.RowHeadersVisible = false;
            this.dgvReporteFinanciero.RowHeadersWidth = 51;
            this.dgvReporteFinanciero.Size = new System.Drawing.Size(1276, 589);
            this.dgvReporteFinanciero.TabIndex = 45;
            // 
            // bnt_Buscar
            // 
            this.bnt_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.bnt_Buscar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.bnt_Buscar, BunifuAnimatorNS.DecorationType.None);
            this.bnt_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_Buscar.Location = new System.Drawing.Point(1174, 24);
            this.bnt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_Buscar.Name = "bnt_Buscar";
            this.bnt_Buscar.Size = new System.Drawing.Size(100, 28);
            this.bnt_Buscar.TabIndex = 44;
            this.bnt_Buscar.Text = "Buscar";
            this.bnt_Buscar.UseVisualStyleBackColor = true;
            this.bnt_Buscar.Click += new System.EventHandler(this.bnt_Buscar_Click);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contraer_menu.SetDecoration(this.dtpFecha2, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.dtpFecha2, BunifuAnimatorNS.DecorationType.None);
            this.dtpFecha2.Location = new System.Drawing.Point(776, 53);
            this.dtpFecha2.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(295, 22);
            this.dtpFecha2.TabIndex = 43;
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contraer_menu.SetDecoration(this.dtpFecha1, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.dtpFecha1, BunifuAnimatorNS.DecorationType.None);
            this.dtpFecha1.Location = new System.Drawing.Point(776, 12);
            this.dtpFecha1.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(295, 22);
            this.dtpFecha1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.contraer_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.contraer_menu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(667, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Desde:";
            // 
            // dgv_ReporteDiario
            // 
            this.dgv_ReporteDiario.AllowUserToAddRows = false;
            this.dgv_ReporteDiario.AllowUserToDeleteRows = false;
            this.dgv_ReporteDiario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ReporteDiario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ReporteDiario.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ReporteDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expandir_menu.SetDecoration(this.dgv_ReporteDiario, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dgv_ReporteDiario, BunifuAnimatorNS.DecorationType.None);
            this.dgv_ReporteDiario.Enabled = false;
            this.dgv_ReporteDiario.Location = new System.Drawing.Point(4, 52);
            this.dgv_ReporteDiario.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ReporteDiario.Name = "dgv_ReporteDiario";
            this.dgv_ReporteDiario.ReadOnly = true;
            this.dgv_ReporteDiario.RowHeadersVisible = false;
            this.dgv_ReporteDiario.RowHeadersWidth = 51;
            this.dgv_ReporteDiario.Size = new System.Drawing.Size(1276, 633);
            this.dgv_ReporteDiario.TabIndex = 46;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.contraer_menu.SetDecoration(this.lbl_Titulo, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.lbl_Titulo, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Titulo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(33, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(169, 24);
            this.lbl_Titulo.TabIndex = 47;
            this.lbl_Titulo.Text = "Reporte Diario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.contraer_menu.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 24);
            this.label6.TabIndex = 48;
            this.label6.Text = "Reporte Mensual";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 788);
            this.Controls.Add(this.tc_Reportes);
            this.Controls.Add(this.btn_maximizar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_restaurar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.contenedor_menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.boton_restaurar);
            this.expandir_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boton_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.contenedor_menu.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_restaurar)).EndInit();
            this.tc_Reportes.ResumeLayout(false);
            this.tp_Mensual.ResumeLayout(false);
            this.tp_Mensual.PerformLayout();
            this.tp_Diario.ResumeLayout(false);
            this.tp_Diario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteFinanciero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReporteDiario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel contenedor_menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator linea_sidebar;
        private Bunifu.Framework.UI.BunifuGradientPanel SideBar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Registro_bodega;
        private Bunifu.Framework.UI.BunifuFlatButton btn_logueo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Inventario_bodega;
        private BunifuAnimatorNS.BunifuTransition expandir_menu;
        private BunifuAnimatorNS.BunifuTransition contraer_menu;
        private Bunifu.Framework.UI.BunifuElipse radio;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.PictureBox boton_restaurar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox boton_max;
        private System.Windows.Forms.PictureBox boton_min;
        private System.Windows.Forms.PictureBox boton_cerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tc_Reportes;
        private System.Windows.Forms.TabPage tp_Mensual;
        private System.Windows.Forms.DataGridView dgvReporteFinanciero;
        private System.Windows.Forms.Button bnt_Buscar;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tp_Diario;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dgv_ReporteDiario;
        private System.Windows.Forms.Label label6;
    }
}