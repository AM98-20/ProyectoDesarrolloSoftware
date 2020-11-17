namespace SiguaSportsApp
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
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambio));
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDevolucion = new System.Windows.Forms.TextBox();
            this.lbldevolucion = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblvendedor = new System.Windows.Forms.Label();
            this.txtvendedor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.lblISV = new System.Windows.Forms.Label();
            this.dgvCambio = new System.Windows.Forms.DataGridView();
            this.columna_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna_motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna_codCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.mtb_Factura = new System.Windows.Forms.MaskedTextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Expandir_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambio)).BeginInit();
            this.panel1.SuspendLayout();
            this.contenedor_menu.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.contraer_menu.SetDecoration(this.txtMotivo, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtMotivo, BunifuAnimatorNS.DecorationType.None);
            this.txtMotivo.Location = new System.Drawing.Point(432, 181);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(427, 20);
            this.txtMotivo.TabIndex = 62;
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
            this.btnConfirmar.Location = new System.Drawing.Point(877, 69);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(83, 23);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblTotal, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblTotal, BunifuAnimatorNS.DecorationType.None);
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(619, 97);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 18);
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
            this.txtTotal.Location = new System.Drawing.Point(682, 98);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDevolucion
            // 
            this.txtDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDevolucion.BackColor = System.Drawing.Color.White;
            this.txtDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraer_menu.SetDecoration(this.txtDevolucion, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtDevolucion, BunifuAnimatorNS.DecorationType.None);
            this.txtDevolucion.Location = new System.Drawing.Point(149, 13);
            this.txtDevolucion.Name = "txtDevolucion";
            this.txtDevolucion.ReadOnly = true;
            this.txtDevolucion.Size = new System.Drawing.Size(133, 20);
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
            this.lbldevolucion.Location = new System.Drawing.Point(22, 13);
            this.lbldevolucion.Name = "lbldevolucion";
            this.lbldevolucion.Size = new System.Drawing.Size(121, 18);
            this.lbldevolucion.TabIndex = 2;
            this.lbldevolucion.Text = "No. De Devolución:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMotivo.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblMotivo, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblMotivo, BunifuAnimatorNS.DecorationType.None);
            this.lblMotivo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(321, 180);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(48, 18);
            this.lblMotivo.TabIndex = 61;
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
            this.panel2.Location = new System.Drawing.Point(220, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 47);
            this.panel2.TabIndex = 57;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.dtp_Fecha, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.dtp_Fecha, BunifuAnimatorNS.DecorationType.None);
            this.dtp_Fecha.Enabled = false;
            this.dtp_Fecha.Location = new System.Drawing.Point(770, 13);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha.TabIndex = 2;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblfecha, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblfecha, BunifuAnimatorNS.DecorationType.None);
            this.lblfecha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(721, 11);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(44, 18);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha";
            // 
            // lblvendedor
            // 
            this.lblvendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblvendedor.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblvendedor, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblvendedor, BunifuAnimatorNS.DecorationType.None);
            this.lblvendedor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvendedor.Location = new System.Drawing.Point(307, 13);
            this.lblvendedor.Name = "lblvendedor";
            this.lblvendedor.Size = new System.Drawing.Size(66, 18);
            this.lblvendedor.TabIndex = 53;
            this.lblvendedor.Text = "Vendedor";
            // 
            // txtvendedor
            // 
            this.txtvendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtvendedor.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.txtvendedor, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtvendedor, BunifuAnimatorNS.DecorationType.None);
            this.txtvendedor.Location = new System.Drawing.Point(386, 12);
            this.txtvendedor.Name = "txtvendedor";
            this.txtvendedor.ReadOnly = true;
            this.txtvendedor.Size = new System.Drawing.Size(309, 20);
            this.txtvendedor.TabIndex = 52;
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
            this.btnCancelar.Location = new System.Drawing.Point(877, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.panel4.Location = new System.Drawing.Point(220, 517);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(980, 134);
            this.panel4.TabIndex = 59;
            // 
            // txtDes
            // 
            this.txtDes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDes.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.txtDes, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtDes, BunifuAnimatorNS.DecorationType.None);
            this.txtDes.Enabled = false;
            this.txtDes.Location = new System.Drawing.Point(682, 44);
            this.txtDes.Name = "txtDes";
            this.txtDes.ReadOnly = true;
            this.txtDes.Size = new System.Drawing.Size(100, 20);
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
            this.lblDes.Location = new System.Drawing.Point(589, 42);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(70, 18);
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
            this.lblSub.Location = new System.Drawing.Point(599, 18);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(60, 18);
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
            this.txtSub.Location = new System.Drawing.Point(682, 19);
            this.txtSub.Name = "txtSub";
            this.txtSub.ReadOnly = true;
            this.txtSub.Size = new System.Drawing.Size(100, 20);
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
            this.txtISV.Location = new System.Drawing.Point(682, 69);
            this.txtISV.Name = "txtISV";
            this.txtISV.ReadOnly = true;
            this.txtISV.Size = new System.Drawing.Size(100, 20);
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
            this.lblISV.Location = new System.Drawing.Point(628, 69);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(32, 18);
            this.lblISV.TabIndex = 5;
            this.lblISV.Text = "ISV";
            // 
            // dgvCambio
            // 
            this.dgvCambio.AllowUserToAddRows = false;
            this.dgvCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCambio.BackgroundColor = System.Drawing.Color.White;
            this.dgvCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCambio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna_codigo,
            this.columna_descripcion,
            this.columna_cantidad,
            this.columna_motivo,
            this.columna_codCambio});
            this.Expandir_menu.SetDecoration(this.dgvCambio, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dgvCambio, BunifuAnimatorNS.DecorationType.None);
            this.dgvCambio.GridColor = System.Drawing.Color.White;
            this.dgvCambio.Location = new System.Drawing.Point(227, 202);
            this.dgvCambio.Name = "dgvCambio";
            this.dgvCambio.ReadOnly = true;
            this.dgvCambio.RowHeadersVisible = false;
            this.dgvCambio.RowHeadersWidth = 51;
            this.dgvCambio.Size = new System.Drawing.Size(1128, 321);
            this.dgvCambio.TabIndex = 64;
            this.dgvCambio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCambio_CellContentClick);
            // 
            // columna_codigo
            // 
            this.columna_codigo.HeaderText = "Producto";
            this.columna_codigo.MinimumWidth = 6;
            this.columna_codigo.Name = "columna_codigo";
            this.columna_codigo.ReadOnly = true;
            this.columna_codigo.Width = 125;
            // 
            // columna_descripcion
            // 
            this.columna_descripcion.HeaderText = "Descripcion";
            this.columna_descripcion.MinimumWidth = 6;
            this.columna_descripcion.Name = "columna_descripcion";
            this.columna_descripcion.ReadOnly = true;
            this.columna_descripcion.Width = 300;
            // 
            // columna_cantidad
            // 
            this.columna_cantidad.HeaderText = "Cantidad";
            this.columna_cantidad.MinimumWidth = 6;
            this.columna_cantidad.Name = "columna_cantidad";
            this.columna_cantidad.ReadOnly = true;
            this.columna_cantidad.Width = 125;
            // 
            // columna_motivo
            // 
            this.columna_motivo.HeaderText = "Motivo";
            this.columna_motivo.MinimumWidth = 6;
            this.columna_motivo.Name = "columna_motivo";
            this.columna_motivo.ReadOnly = true;
            this.columna_motivo.Width = 300;
            // 
            // columna_codCambio
            // 
            this.columna_codCambio.HeaderText = "Codigo Producto";
            this.columna_codCambio.MinimumWidth = 6;
            this.columna_codCambio.Name = "columna_codCambio";
            this.columna_codCambio.ReadOnly = true;
            this.columna_codCambio.Width = 125;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.contraer_menu.SetDecoration(this.txtCodProd, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtCodProd, BunifuAnimatorNS.DecorationType.None);
            this.txtCodProd.Location = new System.Drawing.Point(432, 146);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.ReadOnly = true;
            this.txtCodProd.Size = new System.Drawing.Size(124, 20);
            this.txtCodProd.TabIndex = 66;
            // 
            // lblCodProd
            // 
            this.lblCodProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCodProd.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblCodProd, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblCodProd, BunifuAnimatorNS.DecorationType.None);
            this.lblCodProd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.Location = new System.Drawing.Point(321, 145);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(107, 18);
            this.lblCodProd.TabIndex = 65;
            this.lblCodProd.Text = "Codigo Producto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.btn_maximizar);
            this.panel1.Controls.Add(this.btn_restaurar);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.contraer_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 53);
            this.panel1.TabIndex = 67;
            // 
            // contenedor_menu
            // 
            this.contenedor_menu.Controls.Add(this.Sidebar);
            this.contraer_menu.SetDecoration(this.contenedor_menu, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.contenedor_menu, BunifuAnimatorNS.DecorationType.None);
            this.contenedor_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedor_menu.Location = new System.Drawing.Point(0, 53);
            this.contenedor_menu.Name = "contenedor_menu";
            this.contenedor_menu.Size = new System.Drawing.Size(222, 587);
            this.contenedor_menu.TabIndex = 68;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(11)))));
            this.Sidebar.Location = new System.Drawing.Point(10, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(204, 584);
            this.Sidebar.TabIndex = 0;
            // 
            // btn_logueo
            // 
            this.btn_logueo.Activecolor = System.Drawing.Color.Transparent;
            this.btn_logueo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logueo.BackColor = System.Drawing.Color.Transparent;
            this.btn_logueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logueo.BorderRadius = 0;
            this.btn_logueo.ButtonText = "               CERRAR SESIÓN";
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
            this.btn_logueo.Location = new System.Drawing.Point(6, 532);
            this.btn_logueo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logueo.Name = "btn_logueo";
            this.btn_logueo.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_logueo.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_logueo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_logueo.selected = false;
            this.btn_logueo.Size = new System.Drawing.Size(218, 42);
            this.btn_logueo.TabIndex = 10;
            this.btn_logueo.Text = "               CERRAR SESIÓN";
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
            this.btn_Administracion.Location = new System.Drawing.Point(6, 197);
            this.btn_Administracion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Administracion.Name = "btn_Administracion";
            this.btn_Administracion.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Administracion.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Administracion.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Administracion.selected = false;
            this.btn_Administracion.Size = new System.Drawing.Size(230, 42);
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
            this.btn_Devoluciones.Location = new System.Drawing.Point(6, 128);
            this.btn_Devoluciones.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Devoluciones.Name = "btn_Devoluciones";
            this.btn_Devoluciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Devoluciones.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Devoluciones.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Devoluciones.selected = false;
            this.btn_Devoluciones.Size = new System.Drawing.Size(198, 42);
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
            this.btn_Ventas.Location = new System.Drawing.Point(6, 64);
            this.btn_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Ventas.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Ventas.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Ventas.selected = false;
            this.btn_Ventas.Size = new System.Drawing.Size(176, 42);
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
            this.LineaSidebar.Location = new System.Drawing.Point(3, 40);
            this.LineaSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(198, 10);
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
            this.label2.Location = new System.Drawing.Point(50, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "SiguaSport";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::SiguaSportsApp.Properties.Resources._869bc446_c29f_4183_8a33_8393fdb17213;
            this.pictureBox2.Location = new System.Drawing.Point(9, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_menu
            // 
            this.contraer_menu.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_menu.Image = global::SiguaSportsApp.Properties.Resources.menu;
            this.btn_menu.Location = new System.Drawing.Point(23, 11);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(30, 30);
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
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
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
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.contraer_menu.DefaultAnimation = animation8;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Expandir_menu.SetDecoration(this.btn_Agregar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_Agregar, BunifuAnimatorNS.DecorationType.None);
            this.btn_Agregar.Location = new System.Drawing.Point(712, 120);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(66, 20);
            this.btn_Agregar.TabIndex = 73;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Expandir_menu.SetDecoration(this.btn_Buscar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_Buscar, BunifuAnimatorNS.DecorationType.None);
            this.btn_Buscar.Location = new System.Drawing.Point(712, 120);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(66, 20);
            this.btn_Buscar.TabIndex = 72;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // mtb_Factura
            // 
            this.contraer_menu.SetDecoration(this.mtb_Factura, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.mtb_Factura, BunifuAnimatorNS.DecorationType.None);
            this.mtb_Factura.Location = new System.Drawing.Point(353, 107);
            this.mtb_Factura.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_Factura.Mask = "000-000-00-0000000";
            this.mtb_Factura.Name = "mtb_Factura";
            this.mtb_Factura.Size = new System.Drawing.Size(102, 20);
            this.mtb_Factura.TabIndex = 75;
            // 
            // lblFactura
            // 
            this.lblFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFactura.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.lblFactura, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblFactura, BunifuAnimatorNS.DecorationType.None);
            this.lblFactura.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(241, 106);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(79, 18);
            this.lblFactura.TabIndex = 74;
            this.lblFactura.Text = "No. Factura";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.contraer_menu.SetDecoration(this.txtCantidad, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.txtCantidad, BunifuAnimatorNS.DecorationType.None);
            this.txtCantidad.Location = new System.Drawing.Point(672, 148);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(27, 20);
            this.txtCantidad.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 76;
            this.label3.Text = "Cantidad";
            // 
            // Expandir_menu
            // 
            this.Expandir_menu.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Expandir_menu.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.Expandir_menu.DefaultAnimation = animation7;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimizar.Image = global::SiguaSportsApp.Properties.Resources.minus__1_;
            this.btn_minimizar.Location = new System.Drawing.Point(926, 11);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 79;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.btn_salir.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.btn_salir.Location = new System.Drawing.Point(998, 11);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(30, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 78;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.btn_restaurar.Image = global::SiguaSportsApp.Properties.Resources.window_restore;
            this.btn_restaurar.Location = new System.Drawing.Point(962, 11);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(30, 30);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 81;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click_1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Expandir_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_maximizar.Image = global::SiguaSportsApp.Properties.Resources.maximize__2_;
            this.btn_maximizar.Location = new System.Drawing.Point(962, 11);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(30, 30);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 80;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click_1);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.Expandir_menu.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(455, 15);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(109, 26);
            this.bunifuCustomLabel2.TabIndex = 78;
            this.bunifuCustomLabel2.Text = "Cambio";
            // 
            // FormCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtb_Factura);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.contenedor_menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.lblCodProd);
            this.Controls.Add(this.dgvCambio);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Expandir_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromCambio";
            this.Load += new System.EventHandler(this.FormCambio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contenedor_menu.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDevolucion;
        private System.Windows.Forms.Label lbldevolucion;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtvendedor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblvendedor;
        private System.Windows.Forms.DataGridView dgvCambio;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label lblCodProd;
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
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.MaskedTextBox mtb_Factura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_codCambio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox btn_minimizar;
    }
}