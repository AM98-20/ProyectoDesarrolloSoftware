namespace SiguaSportsApp
{
    partial class FormIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngreso));
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.lblContrasenaOlvidada = new System.Windows.Forms.Label();
            this.txtcontraseñalogin = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TOP = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMostrar
            // 
            this.chkMostrar.AutoSize = true;
            this.chkMostrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrar.Location = new System.Drawing.Point(149, 388);
            this.chkMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(89, 24);
            this.chkMostrar.TabIndex = 27;
            this.chkMostrar.TabStop = false;
            this.chkMostrar.Text = "Mostrar";
            this.chkMostrar.UseVisualStyleBackColor = true;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.chkMostrar_CheckedChanged_1);
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.White;
            this.btningresar.FlatAppearance.BorderSize = 0;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btningresar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.Color.Black;
            this.btningresar.Location = new System.Drawing.Point(149, 431);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(100, 28);
            this.btningresar.TabIndex = 3;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // lblContrasenaOlvidada
            // 
            this.lblContrasenaOlvidada.AutoSize = true;
            this.lblContrasenaOlvidada.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaOlvidada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.lblContrasenaOlvidada.Location = new System.Drawing.Point(53, 505);
            this.lblContrasenaOlvidada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasenaOlvidada.Name = "lblContrasenaOlvidada";
            this.lblContrasenaOlvidada.Size = new System.Drawing.Size(260, 20);
            this.lblContrasenaOlvidada.TabIndex = 25;
            this.lblContrasenaOlvidada.Text = "¿Olvidó su contraseña? Presione aquí";
            this.lblContrasenaOlvidada.Click += new System.EventHandler(this.lblContrasenaOlvidada_Click_1);
            // 
            // txtcontraseñalogin
            // 
            this.txtcontraseñalogin.AccessibleDescription = "Ingrese su contraseña";
            this.txtcontraseñalogin.AccessibleName = "Password";
            this.txtcontraseñalogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseñalogin.Location = new System.Drawing.Point(97, 354);
            this.txtcontraseñalogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontraseñalogin.Name = "txtcontraseñalogin";
            this.txtcontraseñalogin.Size = new System.Drawing.Size(204, 15);
            this.txtcontraseñalogin.TabIndex = 2;
            this.txtcontraseñalogin.TextChanged += new System.EventHandler(this.txtcontraseñalogin_TextChanged_1);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Location = new System.Drawing.Point(97, 244);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(204, 15);
            this.txtUsuario.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.panel1.Location = new System.Drawing.Point(49, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 1);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SiguaSportsApp.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(49, 342);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SiguaSportsApp.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(49, 230);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // TOP
            // 
            this.TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.TOP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TOP.BackgroundImage")));
            this.TOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TOP.Controls.Add(this.label1);
            this.TOP.Controls.Add(this.btn_salir);
            this.TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOP.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.TOP.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.TOP.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.TOP.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(11)))));
            this.TOP.Location = new System.Drawing.Point(0, 0);
            this.TOP.Margin = new System.Windows.Forms.Padding(4);
            this.TOP.Name = "TOP";
            this.TOP.Quality = 10;
            this.TOP.Size = new System.Drawing.Size(427, 41);
            this.TOP.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "LOGIN";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.btn_salir.Location = new System.Drawing.Point(383, 0);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 37);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 29;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.panel2.Location = new System.Drawing.Point(49, 379);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 1);
            this.panel2.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SiguaSportsApp.Properties.Resources._869bc446_c29f_4183_8a33_8393fdb17213;
            this.pictureBox1.Location = new System.Drawing.Point(97, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TOP);
            this.Controls.Add(this.chkMostrar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.lblContrasenaOlvidada);
            this.Controls.Add(this.txtcontraseñalogin);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TOP.ResumeLayout(false);
            this.TOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Label lblContrasenaOlvidada;
        private System.Windows.Forms.TextBox txtcontraseñalogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private Bunifu.Framework.UI.BunifuGradientPanel TOP;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

