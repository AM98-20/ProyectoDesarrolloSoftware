namespace SiguaSportsApp
{
    partial class FormInventarioBodega
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventarioBodega));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.boton_restaurar = new System.Windows.Forms.PictureBox();
            this.contenedor_menu = new System.Windows.Forms.Panel();
            this.SideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Devoluciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_logueo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_reportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Administracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Registro_bodega = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linea_sidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.contraer_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.expandir_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.radio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.boton_cerrar = new System.Windows.Forms.PictureBox();
            this.boton_minimizar = new System.Windows.Forms.PictureBox();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.btn_restaurar_dos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_restaurar)).BeginInit();
            this.contenedor_menu.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.contraer_menu.SetDecoration(this.btnBuscar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btnBuscar, BunifuAnimatorNS.DecorationType.None);
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(998, 111);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 30);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnAgregarProducto_Click_1);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expandir_menu.SetDecoration(this.dgvProductos, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dgvProductos, BunifuAnimatorNS.DecorationType.None);
            this.dgvProductos.Enabled = false;
            this.dgvProductos.Location = new System.Drawing.Point(251, 149);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(701, 371);
            this.dgvProductos.TabIndex = 52;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.contraer_menu.SetDecoration(this.lblBuscar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.lblBuscar, BunifuAnimatorNS.DecorationType.None);
            this.lblBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(692, 79);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(49, 18);
            this.lblBuscar.TabIndex = 50;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.txtBuscar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtBuscar, BunifuAnimatorNS.DecorationType.None);
            this.txtBuscar.Location = new System.Drawing.Point(764, 79);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 20);
            this.txtBuscar.TabIndex = 51;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.boton_minimizar);
            this.panel2.Controls.Add(this.boton_cerrar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_maximizar);
            this.panel2.Controls.Add(this.boton_restaurar);
            this.expandir_menu.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 53);
            this.panel2.TabIndex = 54;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.contraer_menu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(487, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Inventario Bodega";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_maximizar.Image = global::SiguaSportsApp.Properties.Resources.maximize__2_;
            this.btn_maximizar.Location = new System.Drawing.Point(890, 11);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(30, 30);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 59;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // boton_restaurar
            // 
            this.boton_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.boton_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.boton_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.boton_restaurar.Image = global::SiguaSportsApp.Properties.Resources.window_restore;
            this.boton_restaurar.Location = new System.Drawing.Point(890, 11);
            this.boton_restaurar.Name = "boton_restaurar";
            this.boton_restaurar.Size = new System.Drawing.Size(30, 30);
            this.boton_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_restaurar.TabIndex = 60;
            this.boton_restaurar.TabStop = false;
            this.boton_restaurar.Click += new System.EventHandler(this.boton_restaurar_Click);
            // 
            // contenedor_menu
            // 
            this.contenedor_menu.Controls.Add(this.SideBar);
            this.expandir_menu.SetDecoration(this.contenedor_menu, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.contenedor_menu, BunifuAnimatorNS.DecorationType.None);
            this.contenedor_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedor_menu.Location = new System.Drawing.Point(0, 53);
            this.contenedor_menu.Name = "contenedor_menu";
            this.contenedor_menu.Size = new System.Drawing.Size(222, 587);
            this.contenedor_menu.TabIndex = 55;
            // 
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.btn_Devoluciones);
            this.SideBar.Controls.Add(this.btn_logueo);
            this.SideBar.Controls.Add(this.btn_reportes);
            this.SideBar.Controls.Add(this.btn_Administracion);
            this.SideBar.Controls.Add(this.btn_Registro_bodega);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.SideBar.Controls.Add(this.linea_sidebar);
            this.SideBar.Controls.Add(this.label1);
            this.expandir_menu.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.SideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.SideBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(11)))));
            this.SideBar.Location = new System.Drawing.Point(10, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Quality = 10;
            this.SideBar.Size = new System.Drawing.Size(204, 584);
            this.SideBar.TabIndex = 0;
            // 
            // btn_Devoluciones
            // 
            this.btn_Devoluciones.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Devoluciones.BackColor = System.Drawing.Color.Transparent;
            this.btn_Devoluciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Devoluciones.BorderRadius = 0;
            this.btn_Devoluciones.ButtonText = "            DEVOLUCIONES";
            this.btn_Devoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contraer_menu.SetDecoration(this.btn_Devoluciones, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_Devoluciones, BunifuAnimatorNS.DecorationType.None);
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
            this.btn_Devoluciones.Location = new System.Drawing.Point(2, 250);
            this.btn_Devoluciones.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Devoluciones.Name = "btn_Devoluciones";
            this.btn_Devoluciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Devoluciones.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Devoluciones.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Devoluciones.selected = false;
            this.btn_Devoluciones.Size = new System.Drawing.Size(224, 42);
            this.btn_Devoluciones.TabIndex = 61;
            this.btn_Devoluciones.Text = "            DEVOLUCIONES";
            this.btn_Devoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Devoluciones.Textcolor = System.Drawing.Color.White;
            this.btn_Devoluciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Devoluciones.Click += new System.EventHandler(this.btn_Devoluciones_Click);
            // 
            // btn_logueo
            // 
            this.btn_logueo.Activecolor = System.Drawing.Color.Transparent;
            this.btn_logueo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logueo.BackColor = System.Drawing.Color.Transparent;
            this.btn_logueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logueo.BorderRadius = 0;
            this.btn_logueo.ButtonText = "            CERRAR SESIÓN";
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
            this.btn_logueo.Location = new System.Drawing.Point(6, 532);
            this.btn_logueo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logueo.Name = "btn_logueo";
            this.btn_logueo.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_logueo.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_logueo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_logueo.selected = false;
            this.btn_logueo.Size = new System.Drawing.Size(220, 42);
            this.btn_logueo.TabIndex = 11;
            this.btn_logueo.Text = "            CERRAR SESIÓN";
            this.btn_logueo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logueo.Textcolor = System.Drawing.Color.White;
            this.btn_logueo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logueo.Click += new System.EventHandler(this.btn_logueo_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Activecolor = System.Drawing.Color.Transparent;
            this.btn_reportes.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reportes.BorderRadius = 0;
            this.btn_reportes.ButtonText = "            REPORTES";
            this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contraer_menu.SetDecoration(this.btn_reportes, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_reportes, BunifuAnimatorNS.DecorationType.None);
            this.btn_reportes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_reportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_reportes.Iconimage = global::SiguaSportsApp.Properties.Resources.report;
            this.btn_reportes.Iconimage_right = null;
            this.btn_reportes.Iconimage_right_Selected = null;
            this.btn_reportes.Iconimage_Selected = null;
            this.btn_reportes.IconMarginLeft = 0;
            this.btn_reportes.IconMarginRight = 0;
            this.btn_reportes.IconRightVisible = true;
            this.btn_reportes.IconRightZoom = 0D;
            this.btn_reportes.IconVisible = true;
            this.btn_reportes.IconZoom = 85D;
            this.btn_reportes.IsTab = false;
            this.btn_reportes.Location = new System.Drawing.Point(3, 123);
            this.btn_reportes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_reportes.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_reportes.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_reportes.selected = false;
            this.btn_reportes.Size = new System.Drawing.Size(232, 42);
            this.btn_reportes.TabIndex = 10;
            this.btn_reportes.Text = "            REPORTES";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Textcolor = System.Drawing.Color.White;
            this.btn_reportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_Administracion
            // 
            this.btn_Administracion.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Administracion.BackColor = System.Drawing.Color.Transparent;
            this.btn_Administracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Administracion.BorderRadius = 0;
            this.btn_Administracion.ButtonText = "           ADMINISTRACIÓN";
            this.btn_Administracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contraer_menu.SetDecoration(this.btn_Administracion, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_Administracion, BunifuAnimatorNS.DecorationType.None);
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
            this.btn_Administracion.Location = new System.Drawing.Point(6, 58);
            this.btn_Administracion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Administracion.Name = "btn_Administracion";
            this.btn_Administracion.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Administracion.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Administracion.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Administracion.selected = false;
            this.btn_Administracion.Size = new System.Drawing.Size(232, 42);
            this.btn_Administracion.TabIndex = 8;
            this.btn_Administracion.Text = "           ADMINISTRACIÓN";
            this.btn_Administracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Administracion.Textcolor = System.Drawing.Color.White;
            this.btn_Administracion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Administracion.Click += new System.EventHandler(this.btn_Administracion_Click);
            // 
            // btn_Registro_bodega
            // 
            this.btn_Registro_bodega.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Registro_bodega.BackColor = System.Drawing.Color.Transparent;
            this.btn_Registro_bodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Registro_bodega.BorderRadius = 0;
            this.btn_Registro_bodega.ButtonText = "          REGISTRO";
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
            this.btn_Registro_bodega.Location = new System.Drawing.Point(6, 188);
            this.btn_Registro_bodega.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Registro_bodega.Name = "btn_Registro_bodega";
            this.btn_Registro_bodega.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Registro_bodega.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Registro_bodega.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Registro_bodega.selected = false;
            this.btn_Registro_bodega.Size = new System.Drawing.Size(250, 42);
            this.btn_Registro_bodega.TabIndex = 7;
            this.btn_Registro_bodega.Text = "          REGISTRO";
            this.btn_Registro_bodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registro_bodega.Textcolor = System.Drawing.Color.White;
            this.btn_Registro_bodega.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registro_bodega.Click += new System.EventHandler(this.btn_Registro_bodega_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::SiguaSportsApp.Properties.Resources._869bc446_c29f_4183_8a33_8393fdb17213;
            this.pictureBox1.Location = new System.Drawing.Point(9, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // linea_sidebar
            // 
            this.linea_sidebar.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.linea_sidebar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.linea_sidebar, BunifuAnimatorNS.DecorationType.None);
            this.linea_sidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linea_sidebar.LineThickness = 1;
            this.linea_sidebar.Location = new System.Drawing.Point(3, 40);
            this.linea_sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.linea_sidebar.Name = "linea_sidebar";
            this.linea_sidebar.Size = new System.Drawing.Size(198, 10);
            this.linea_sidebar.TabIndex = 1;
            this.linea_sidebar.Transparency = 255;
            this.linea_sidebar.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.contraer_menu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "SiguaSport";
            // 
            // contraer_menu
            // 
            this.contraer_menu.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.contraer_menu.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.contraer_menu.DefaultAnimation = animation1;
            // 
            // btn_menu
            // 
            this.contraer_menu.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_menu.Image = global::SiguaSportsApp.Properties.Resources.menu;
            this.btn_menu.Location = new System.Drawing.Point(23, 11);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(30, 30);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menu.TabIndex = 56;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.contraer_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "MENÚ";
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.btn_salir.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.btn_salir.Location = new System.Drawing.Point(1085, 11);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(30, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 58;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.btn_restaurar.Image = global::SiguaSportsApp.Properties.Resources.window_restore;
            this.btn_restaurar.Location = new System.Drawing.Point(1049, 11);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(30, 30);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 60;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimizar.Image = global::SiguaSportsApp.Properties.Resources.minus__1_;
            this.btn_minimizar.Location = new System.Drawing.Point(1013, 11);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 61;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // expandir_menu
            // 
            this.expandir_menu.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.expandir_menu.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.expandir_menu.DefaultAnimation = animation2;
            // 
            // radio
            // 
            this.radio.ElipseRadius = 5;
            this.radio.TargetControl = this.SideBar;
            // 
            // boton_cerrar
            // 
            this.boton_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.boton_cerrar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.boton_cerrar, BunifuAnimatorNS.DecorationType.None);
            this.boton_cerrar.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.boton_cerrar.Location = new System.Drawing.Point(925, 11);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(30, 30);
            this.boton_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerrar.TabIndex = 62;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Click += new System.EventHandler(this.boton_cerrar_Click);
            // 
            // boton_minimizar
            // 
            this.boton_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.boton_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.boton_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.boton_minimizar.Image = global::SiguaSportsApp.Properties.Resources.minus__1_;
            this.boton_minimizar.Location = new System.Drawing.Point(853, 11);
            this.boton_minimizar.Name = "boton_minimizar";
            this.boton_minimizar.Size = new System.Drawing.Size(30, 30);
            this.boton_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_minimizar.TabIndex = 63;
            this.boton_minimizar.TabStop = false;
            this.boton_minimizar.Click += new System.EventHandler(this.boton_minimizar_Click);
            // 
            // boton_buscar
            // 
            this.boton_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.boton_buscar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.boton_buscar, BunifuAnimatorNS.DecorationType.None);
            this.boton_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_buscar.Location = new System.Drawing.Point(780, 105);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(75, 23);
            this.boton_buscar.TabIndex = 62;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // btn_restaurar_dos
            // 
            this.btn_restaurar_dos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_restaurar_dos, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_restaurar_dos, BunifuAnimatorNS.DecorationType.None);
            this.btn_restaurar_dos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restaurar_dos.Location = new System.Drawing.Point(877, 105);
            this.btn_restaurar_dos.Name = "btn_restaurar_dos";
            this.btn_restaurar_dos.Size = new System.Drawing.Size(75, 23);
            this.btn_restaurar_dos.TabIndex = 63;
            this.btn_restaurar_dos.Text = "Restaurar";
            this.btn_restaurar_dos.UseVisualStyleBackColor = true;
            this.btn_restaurar_dos.Click += new System.EventHandler(this.btn_restaurar_dos_Click);
            // 
            // FormInventarioBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 640);
            this.Controls.Add(this.btn_restaurar_dos);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.contenedor_menu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btn_restaurar);
            this.expandir_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInventarioBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInventarioBodega";
            this.Load += new System.EventHandler(this.FormInventarioBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_restaurar)).EndInit();
            this.contenedor_menu.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel contenedor_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator linea_sidebar;
        private Bunifu.Framework.UI.BunifuGradientPanel SideBar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_logueo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_reportes;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Administracion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Registro_bodega;
        private BunifuAnimatorNS.BunifuTransition expandir_menu;
        private BunifuAnimatorNS.BunifuTransition contraer_menu;
        private Bunifu.Framework.UI.BunifuElipse radio;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox boton_restaurar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Devoluciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox boton_minimizar;
        private System.Windows.Forms.PictureBox boton_cerrar;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Button btn_restaurar_dos;
    }
}