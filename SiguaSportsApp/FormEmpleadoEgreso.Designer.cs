namespace SiguaSportsApp
{
    partial class FormEmpleadoEgreso
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleadoEgreso));
            this.dgvEgreso = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.contenedor_menu = new System.Windows.Forms.Panel();
            this.SideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_reportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_logueo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Registro_bodega = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Administracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Inventario_bodega = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linea_sidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contraer_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.expandir_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.radio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgreso)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            this.contenedor_menu.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEgreso
            // 
            this.dgvEgreso.AllowUserToAddRows = false;
            this.dgvEgreso.AllowUserToDeleteRows = false;
            this.dgvEgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEgreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEgreso.BackgroundColor = System.Drawing.Color.White;
            this.dgvEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Codigo,
            this.FechaNaci,
            this.Telefono});
            this.expandir_menu.SetDecoration(this.dgvEgreso, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dgvEgreso, BunifuAnimatorNS.DecorationType.None);
            this.dgvEgreso.Enabled = false;
            this.dgvEgreso.Location = new System.Drawing.Point(304, 79);
            this.dgvEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEgreso.Name = "dgvEgreso";
            this.dgvEgreso.ReadOnly = true;
            this.dgvEgreso.RowHeadersVisible = false;
            this.dgvEgreso.RowHeadersWidth = 51;
            this.dgvEgreso.Size = new System.Drawing.Size(1280, 535);
            this.dgvEgreso.TabIndex = 22;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // FechaNaci
            // 
            this.FechaNaci.HeaderText = "Fecha de Nacimiento";
            this.FechaNaci.MinimumWidth = 6;
            this.FechaNaci.Name = "FechaNaci";
            this.FechaNaci.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono(s)";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contraer_menu.SetDecoration(this.btnEliminar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btnEliminar, BunifuAnimatorNS.DecorationType.None);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(1044, 644);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 39);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contraer_menu.SetDecoration(this.btnCancelar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btnCancelar, BunifuAnimatorNS.DecorationType.None);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(764, 644);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 39);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_restaurar);
            this.expandir_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 65);
            this.panel1.TabIndex = 25;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.btn_restaurar.Image = global::SiguaSportsApp.Properties.Resources.window_restore;
            this.btn_restaurar.Location = new System.Drawing.Point(1496, 14);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(40, 37);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 30;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
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
            this.contenedor_menu.Size = new System.Drawing.Size(296, 737);
            this.contenedor_menu.TabIndex = 26;
            // 
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.btn_reportes);
            this.SideBar.Controls.Add(this.btn_logueo);
            this.SideBar.Controls.Add(this.btn_Registro_bodega);
            this.SideBar.Controls.Add(this.btn_Administracion);
            this.SideBar.Controls.Add(this.btn_Inventario_bodega);
            this.SideBar.Controls.Add(this.linea_sidebar);
            this.SideBar.Controls.Add(this.label1);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.expandir_menu.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.SideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.SideBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(11)))));
            this.SideBar.Location = new System.Drawing.Point(13, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(4);
            this.SideBar.Name = "SideBar";
            this.SideBar.Quality = 10;
            this.SideBar.Size = new System.Drawing.Size(272, 734);
            this.SideBar.TabIndex = 0;
            // 
            // btn_reportes
            // 
            this.btn_reportes.Activecolor = System.Drawing.Color.Transparent;
            this.btn_reportes.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reportes.BorderRadius = 0;
            this.btn_reportes.ButtonText = "              REPORTES";
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
            this.btn_reportes.Location = new System.Drawing.Point(8, 324);
            this.btn_reportes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_reportes.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_reportes.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_reportes.selected = false;
            this.btn_reportes.Size = new System.Drawing.Size(270, 52);
            this.btn_reportes.TabIndex = 9;
            this.btn_reportes.Text = "              REPORTES";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Textcolor = System.Drawing.Color.White;
            this.btn_reportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_logueo
            // 
            this.btn_logueo.Activecolor = System.Drawing.Color.Transparent;
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
            this.btn_logueo.Location = new System.Drawing.Point(8, 655);
            this.btn_logueo.Margin = new System.Windows.Forms.Padding(5);
            this.btn_logueo.Name = "btn_logueo";
            this.btn_logueo.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_logueo.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_logueo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_logueo.selected = false;
            this.btn_logueo.Size = new System.Drawing.Size(287, 52);
            this.btn_logueo.TabIndex = 8;
            this.btn_logueo.Text = "              CERRAR SESIÓN";
            this.btn_logueo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logueo.Textcolor = System.Drawing.Color.White;
            this.btn_logueo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logueo.Click += new System.EventHandler(this.btn_logueo_Click);
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
            this.btn_Registro_bodega.Location = new System.Drawing.Point(8, 243);
            this.btn_Registro_bodega.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Registro_bodega.Name = "btn_Registro_bodega";
            this.btn_Registro_bodega.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Registro_bodega.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Registro_bodega.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Registro_bodega.selected = false;
            this.btn_Registro_bodega.Size = new System.Drawing.Size(306, 52);
            this.btn_Registro_bodega.TabIndex = 7;
            this.btn_Registro_bodega.Text = "              REGISTRO - BODEGA";
            this.btn_Registro_bodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registro_bodega.Textcolor = System.Drawing.Color.White;
            this.btn_Registro_bodega.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registro_bodega.Click += new System.EventHandler(this.btn_Registro_bodega_Click);
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
            this.btn_Administracion.Location = new System.Drawing.Point(8, 71);
            this.btn_Administracion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Administracion.Name = "btn_Administracion";
            this.btn_Administracion.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Administracion.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Administracion.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Administracion.selected = false;
            this.btn_Administracion.Size = new System.Drawing.Size(287, 52);
            this.btn_Administracion.TabIndex = 6;
            this.btn_Administracion.Text = "              ADMINISTRACIÓN";
            this.btn_Administracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Administracion.Textcolor = System.Drawing.Color.White;
            this.btn_Administracion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Administracion.Click += new System.EventHandler(this.btn_Administracion_Click);
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
            this.btn_Inventario_bodega.Location = new System.Drawing.Point(8, 156);
            this.btn_Inventario_bodega.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Inventario_bodega.Name = "btn_Inventario_bodega";
            this.btn_Inventario_bodega.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Inventario_bodega.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Inventario_bodega.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Inventario_bodega.selected = false;
            this.btn_Inventario_bodega.Size = new System.Drawing.Size(323, 52);
            this.btn_Inventario_bodega.TabIndex = 5;
            this.btn_Inventario_bodega.Text = "              INVENTARIO-BODEGA";
            this.btn_Inventario_bodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventario_bodega.Textcolor = System.Drawing.Color.White;
            this.btn_Inventario_bodega.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventario_bodega.Click += new System.EventHandler(this.btn_Inventario_bodega_Click);
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
            this.linea_sidebar.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(73, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SiguaSport";
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
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btn_menu.TabIndex = 27;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.btn_salir.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.btn_salir.Location = new System.Drawing.Point(1544, 14);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 37);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 28;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.contraer_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "MENÚ";
            // 
            // contraer_menu
            // 
            this.contraer_menu.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.contraer_menu.Cursor = null;
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
            this.contraer_menu.DefaultAnimation = animation2;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimizar.Image = global::SiguaSportsApp.Properties.Resources.minus__1_;
            this.btn_minimizar.Location = new System.Drawing.Point(1448, 14);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(40, 37);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 31;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_maximizar.Image = global::SiguaSportsApp.Properties.Resources.maximize__2_;
            this.btn_maximizar.Location = new System.Drawing.Point(1496, 14);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(40, 37);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 32;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // expandir_menu
            // 
            this.expandir_menu.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.expandir_menu.Cursor = null;
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
            this.expandir_menu.DefaultAnimation = animation1;
            // 
            // radio
            // 
            this.radio.ElipseRadius = 5;
            this.radio.TargetControl = this.SideBar;
            // 
            // FormEmpleadoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 802);
            this.Controls.Add(this.btn_maximizar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.contenedor_menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEgreso);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.expandir_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEmpleadoEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpleadoEgreso";
            this.Load += new System.EventHandler(this.FormEmpleadoEgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgreso)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            this.contenedor_menu.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel contenedor_menu;
        private Bunifu.Framework.UI.BunifuGradientPanel SideBar;
        private Bunifu.Framework.UI.BunifuSeparator linea_sidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_reportes;
        private Bunifu.Framework.UI.BunifuFlatButton btn_logueo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Registro_bodega;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Administracion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Inventario_bodega;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition expandir_menu;
        private BunifuAnimatorNS.BunifuTransition contraer_menu;
        private Bunifu.Framework.UI.BunifuElipse radio;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_maximizar;
    }
}