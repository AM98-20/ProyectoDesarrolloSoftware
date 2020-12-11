namespace SiguaSportsApp
{
    partial class FormEmpleadoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleadoNuevo));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.cb_Genero = new System.Windows.Forms.ComboBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.mtxttelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.contenedor_menu = new System.Windows.Forms.Panel();
            this.SideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Registro_bodega = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Administracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_reportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_logueo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Inventario_bodega = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.linea_sidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contraer_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.txt_Contrasena = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Contrasena = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Confirmacion = new System.Windows.Forms.Label();
            this.txt_Confirmacion = new System.Windows.Forms.TextBox();
            this.lblDAtos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Puesto = new System.Windows.Forms.Label();
            this.cb_Puesto = new System.Windows.Forms.ComboBox();
            this.dtp_FechaNAc = new System.Windows.Forms.DateTimePicker();
            this.expandir_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            this.contenedor_menu.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Genero
            // 
            this.cb_Genero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_Genero.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.cb_Genero, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.cb_Genero, BunifuAnimatorNS.DecorationType.None);
            this.cb_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Genero.FormattingEnabled = true;
            this.cb_Genero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Genero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cb_Genero.Location = new System.Drawing.Point(568, 478);
            this.cb_Genero.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Genero.Name = "cb_Genero";
            this.cb_Genero.Size = new System.Drawing.Size(169, 24);
            this.cb_Genero.Sorted = true;
            this.cb_Genero.TabIndex = 36;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contraer_menu.SetDecoration(this.txtApellidos, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtApellidos, BunifuAnimatorNS.DecorationType.None);
            this.txtApellidos.Location = new System.Drawing.Point(568, 204);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(244, 22);
            this.txtApellidos.TabIndex = 34;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contraer_menu.SetDecoration(this.txtNombre, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtNombre, BunifuAnimatorNS.DecorationType.None);
            this.txtNombre.Location = new System.Drawing.Point(568, 142);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 22);
            this.txtNombre.TabIndex = 31;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expandir_menu.SetDecoration(this.btnAgregar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btnAgregar, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(1237, 743);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expandir_menu.SetDecoration(this.btnCancelar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btnCancelar, BunifuAnimatorNS.DecorationType.None);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(1091, 743);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lblFechaNacimiento, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblFechaNacimiento, BunifuAnimatorNS.DecorationType.None);
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(344, 263);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(204, 25);
            this.lblFechaNacimiento.TabIndex = 28;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lblTelefono, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblTelefono, BunifuAnimatorNS.DecorationType.None);
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(344, 402);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 25);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lblGenero, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblGenero, BunifuAnimatorNS.DecorationType.None);
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(344, 476);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(88, 25);
            this.lblGenero.TabIndex = 24;
            this.lblGenero.Text = "Género: ";
            // 
            // lblApellidos
            // 
            this.lblApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lblApellidos, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblApellidos, BunifuAnimatorNS.DecorationType.None);
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(344, 204);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(112, 25);
            this.lblApellidos.TabIndex = 23;
            this.lblApellidos.Text = "Apellido(s):";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(344, 139);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(111, 25);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre(s):";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lblCorreo, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblCorreo, BunifuAnimatorNS.DecorationType.None);
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(344, 335);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(179, 25);
            this.lblCorreo.TabIndex = 26;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // mtxttelefono
            // 
            this.mtxttelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.expandir_menu.SetDecoration(this.mtxttelefono, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.mtxttelefono, BunifuAnimatorNS.DecorationType.None);
            this.mtxttelefono.Location = new System.Drawing.Point(569, 406);
            this.mtxttelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxttelefono.Mask = "0000-0000";
            this.mtxttelefono.Name = "mtxttelefono";
            this.mtxttelefono.Size = new System.Drawing.Size(109, 22);
            this.mtxttelefono.TabIndex = 38;
            this.mtxttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contraer_menu.SetDecoration(this.txtCorreo, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtCorreo, BunifuAnimatorNS.DecorationType.None);
            this.txtCorreo.Location = new System.Drawing.Point(569, 337);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(243, 22);
            this.txtCorreo.TabIndex = 39;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_maximizar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_restaurar);
            this.expandir_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 65);
            this.panel1.TabIndex = 40;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_maximizar.Image = global::SiguaSportsApp.Properties.Resources.maximize__2_;
            this.btn_maximizar.Location = new System.Drawing.Point(1285, 14);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(40, 37);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 46;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.expandir_menu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(677, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 29);
            this.label5.TabIndex = 59;
            this.label5.Text = "Empleado Nuevo";
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.btn_restaurar.Image = global::SiguaSportsApp.Properties.Resources.window_restore;
            this.btn_restaurar.Location = new System.Drawing.Point(1285, 15);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(40, 37);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 45;
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
            this.contenedor_menu.Size = new System.Drawing.Size(296, 723);
            this.contenedor_menu.TabIndex = 41;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.btn_Registro_bodega);
            this.SideBar.Controls.Add(this.btn_Administracion);
            this.SideBar.Controls.Add(this.btn_reportes);
            this.SideBar.Controls.Add(this.btn_logueo);
            this.SideBar.Controls.Add(this.btn_Inventario_bodega);
            this.SideBar.Controls.Add(this.label1);
            this.SideBar.Controls.Add(this.linea_sidebar);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.contraer_menu.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
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
            this.btn_Registro_bodega.ButtonText = "               REGISTRO ";
            this.btn_Registro_bodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandir_menu.SetDecoration(this.btn_Registro_bodega, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_Registro_bodega, BunifuAnimatorNS.DecorationType.None);
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
            this.btn_Registro_bodega.Location = new System.Drawing.Point(8, 242);
            this.btn_Registro_bodega.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Registro_bodega.Name = "btn_Registro_bodega";
            this.btn_Registro_bodega.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Registro_bodega.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Registro_bodega.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Registro_bodega.selected = false;
            this.btn_Registro_bodega.Size = new System.Drawing.Size(320, 52);
            this.btn_Registro_bodega.TabIndex = 10;
            this.btn_Registro_bodega.Text = "               REGISTRO ";
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
            this.expandir_menu.SetDecoration(this.btn_Administracion, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_Administracion, BunifuAnimatorNS.DecorationType.None);
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
            this.btn_Administracion.Location = new System.Drawing.Point(8, 76);
            this.btn_Administracion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Administracion.Name = "btn_Administracion";
            this.btn_Administracion.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Administracion.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Administracion.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Administracion.selected = false;
            this.btn_Administracion.Size = new System.Drawing.Size(295, 52);
            this.btn_Administracion.TabIndex = 9;
            this.btn_Administracion.Text = "              ADMINISTRACIÓN";
            this.btn_Administracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Administracion.Textcolor = System.Drawing.Color.White;
            this.btn_Administracion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Administracion.Click += new System.EventHandler(this.btn_Administracion_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Activecolor = System.Drawing.Color.Transparent;
            this.btn_reportes.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reportes.BorderRadius = 0;
            this.btn_reportes.ButtonText = "               REPORTES";
            this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandir_menu.SetDecoration(this.btn_reportes, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_reportes, BunifuAnimatorNS.DecorationType.None);
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
            this.btn_reportes.Size = new System.Drawing.Size(295, 52);
            this.btn_reportes.TabIndex = 7;
            this.btn_reportes.Text = "               REPORTES";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Textcolor = System.Drawing.Color.White;
            this.btn_reportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
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
            this.expandir_menu.SetDecoration(this.btn_logueo, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_logueo, BunifuAnimatorNS.DecorationType.None);
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
            this.btn_logueo.Size = new System.Drawing.Size(275, 52);
            this.btn_logueo.TabIndex = 6;
            this.btn_logueo.Text = "             CERRAR SESIÓN";
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
            this.btn_Inventario_bodega.ButtonText = "               INVENTARIO";
            this.btn_Inventario_bodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandir_menu.SetDecoration(this.btn_Inventario_bodega, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_Inventario_bodega, BunifuAnimatorNS.DecorationType.None);
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
            this.btn_Inventario_bodega.Size = new System.Drawing.Size(331, 52);
            this.btn_Inventario_bodega.TabIndex = 5;
            this.btn_Inventario_bodega.Text = "               INVENTARIO";
            this.btn_Inventario_bodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventario_bodega.Textcolor = System.Drawing.Color.White;
            this.btn_Inventario_bodega.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventario_bodega.Click += new System.EventHandler(this.btn_Inventario_bodega_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "SiguaSport";
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
            // btn_menu
            // 
            this.contraer_menu.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_menu.Image = global::SiguaSportsApp.Properties.Resources.menu;
            this.btn_menu.Location = new System.Drawing.Point(31, 14);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(40, 37);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_menu.TabIndex = 42;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.expandir_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "MENÚ";
            // 
            // radio
            // 
            this.radio.ElipseRadius = 5;
            this.radio.TargetControl = this.SideBar;
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
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.btn_salir.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.btn_salir.Location = new System.Drawing.Point(1333, 14);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 37);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 44;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimizar.Image = global::SiguaSportsApp.Properties.Resources.minus__1_;
            this.btn_minimizar.Location = new System.Drawing.Point(1237, 14);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(40, 37);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 47;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // txt_Contrasena
            // 
            this.txt_Contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.txt_Contrasena, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txt_Contrasena, BunifuAnimatorNS.DecorationType.None);
            this.txt_Contrasena.Location = new System.Drawing.Point(1035, 267);
            this.txt_Contrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contrasena.Name = "txt_Contrasena";
            this.txt_Contrasena.PasswordChar = '*';
            this.txt_Contrasena.Size = new System.Drawing.Size(244, 22);
            this.txt_Contrasena.TabIndex = 51;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.txt_Usuario, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txt_Usuario, BunifuAnimatorNS.DecorationType.None);
            this.txt_Usuario.Location = new System.Drawing.Point(1035, 204);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(244, 22);
            this.txt_Usuario.TabIndex = 50;
            // 
            // lbl_Contrasena
            // 
            this.lbl_Contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Contrasena.AutoSize = true;
            this.lbl_Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lbl_Contrasena, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lbl_Contrasena, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contrasena.Location = new System.Drawing.Point(879, 267);
            this.lbl_Contrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Contrasena.Name = "lbl_Contrasena";
            this.lbl_Contrasena.Size = new System.Drawing.Size(120, 25);
            this.lbl_Contrasena.TabIndex = 49;
            this.lbl_Contrasena.Text = "Contraseña:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lbl_Usuario, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lbl_Usuario, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(879, 202);
            this.lbl_Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(85, 25);
            this.lbl_Usuario.TabIndex = 48;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // lbl_Confirmacion
            // 
            this.lbl_Confirmacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Confirmacion.AutoSize = true;
            this.lbl_Confirmacion.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lbl_Confirmacion, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lbl_Confirmacion, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Confirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirmacion.Location = new System.Drawing.Point(879, 326);
            this.lbl_Confirmacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Confirmacion.Name = "lbl_Confirmacion";
            this.lbl_Confirmacion.Size = new System.Drawing.Size(133, 25);
            this.lbl_Confirmacion.TabIndex = 52;
            this.lbl_Confirmacion.Text = "Confirmación:";
            // 
            // txt_Confirmacion
            // 
            this.txt_Confirmacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.txt_Confirmacion, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txt_Confirmacion, BunifuAnimatorNS.DecorationType.None);
            this.txt_Confirmacion.Location = new System.Drawing.Point(1035, 326);
            this.txt_Confirmacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Confirmacion.Name = "txt_Confirmacion";
            this.txt_Confirmacion.PasswordChar = '*';
            this.txt_Confirmacion.Size = new System.Drawing.Size(244, 22);
            this.txt_Confirmacion.TabIndex = 53;
            // 
            // lblDAtos
            // 
            this.lblDAtos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDAtos.AutoSize = true;
            this.lblDAtos.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lblDAtos, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblDAtos, BunifuAnimatorNS.DecorationType.None);
            this.lblDAtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDAtos.Location = new System.Drawing.Point(365, 94);
            this.lblDAtos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDAtos.Name = "lblDAtos";
            this.lblDAtos.Size = new System.Drawing.Size(208, 25);
            this.lblDAtos.TabIndex = 54;
            this.lblDAtos.Text = "DATOS GENERALES";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(955, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "USUARIO";
            // 
            // lbl_Puesto
            // 
            this.lbl_Puesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Puesto.AutoSize = true;
            this.lbl_Puesto.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.lbl_Puesto, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lbl_Puesto, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Puesto.Location = new System.Drawing.Point(879, 386);
            this.lbl_Puesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Puesto.Name = "lbl_Puesto";
            this.lbl_Puesto.Size = new System.Drawing.Size(84, 25);
            this.lbl_Puesto.TabIndex = 56;
            this.lbl_Puesto.Text = "Puesto: ";
            // 
            // cb_Puesto
            // 
            this.cb_Puesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.cb_Puesto, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.cb_Puesto, BunifuAnimatorNS.DecorationType.None);
            this.cb_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Puesto.FormattingEnabled = true;
            this.cb_Puesto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Puesto.Items.AddRange(new object[] {
            "Administracion",
            "Bodega",
            "Ventas"});
            this.cb_Puesto.Location = new System.Drawing.Point(1035, 391);
            this.cb_Puesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Puesto.Name = "cb_Puesto";
            this.cb_Puesto.Size = new System.Drawing.Size(227, 24);
            this.cb_Puesto.TabIndex = 57;
            // 
            // dtp_FechaNAc
            // 
            this.dtp_FechaNAc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.expandir_menu.SetDecoration(this.dtp_FechaNAc, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dtp_FechaNAc, BunifuAnimatorNS.DecorationType.None);
            this.dtp_FechaNAc.Location = new System.Drawing.Point(568, 265);
            this.dtp_FechaNAc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_FechaNAc.Name = "dtp_FechaNAc";
            this.dtp_FechaNAc.Size = new System.Drawing.Size(244, 22);
            this.dtp_FechaNAc.TabIndex = 58;
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
            // FormEmpleadoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.dtp_FechaNAc);
            this.Controls.Add(this.cb_Puesto);
            this.Controls.Add(this.lbl_Puesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDAtos);
            this.Controls.Add(this.txt_Confirmacion);
            this.Controls.Add(this.lbl_Confirmacion);
            this.Controls.Add(this.txt_Contrasena);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Contrasena);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.contenedor_menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.mtxttelefono);
            this.Controls.Add(this.cb_Genero);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.expandir_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEmpleadoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpleadoNuevo";
            this.Load += new System.EventHandler(this.FormEmpleadoNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            this.contenedor_menu.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_Genero;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.MaskedTextBox mtxttelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel contenedor_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator linea_sidebar;
        private Bunifu.Framework.UI.BunifuGradientPanel SideBar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Registro_bodega;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Administracion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_reportes;
        private Bunifu.Framework.UI.BunifuFlatButton btn_logueo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Inventario_bodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_menu;
        private Bunifu.Framework.UI.BunifuElipse radio;
        private BunifuAnimatorNS.BunifuTransition contraer_menu;
        private BunifuAnimatorNS.BunifuTransition expandir_menu;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.TextBox txt_Confirmacion;
        private System.Windows.Forms.Label lbl_Confirmacion;
        private System.Windows.Forms.TextBox txt_Contrasena;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label lbl_Contrasena;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDAtos;
        private System.Windows.Forms.Label lbl_Puesto;
        private System.Windows.Forms.ComboBox cb_Puesto;
        private System.Windows.Forms.DateTimePicker dtp_FechaNAc;
        private System.Windows.Forms.Label label5;
    }
}