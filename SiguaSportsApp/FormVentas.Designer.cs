using System;

namespace SiguaSportsApp
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btndevoluciones = new System.Windows.Forms.Button();
            this.txtcodigoproducto = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvventas = new System.Windows.Forms.DataGridView();
            this.columna_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_FechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtvendedor = new System.Windows.Forms.TextBox();
            this.lblvendedor = new System.Windows.Forms.Label();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.lblfactura = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.boton_salir = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.contenedor_menu = new System.Windows.Forms.Panel();
            this.SideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_logueo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Cambio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Administracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Devoluciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linea_sidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.radio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contraer_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.btn_AgregarProd = new System.Windows.Forms.Button();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.expandir_menu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boton_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            this.contenedor_menu.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotal.AutoSize = true;
            this.expandir_menu.SetDecoration(this.lbltotal, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lbltotal, BunifuAnimatorNS.DecorationType.None);
            this.lbltotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(653, 92);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(40, 18);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.BackColor = System.Drawing.Color.White;
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraer_menu.SetDecoration(this.txttotal, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txttotal, BunifuAnimatorNS.DecorationType.None);
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(716, 94);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 2;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btndevoluciones
            // 
            this.btndevoluciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expandir_menu.SetDecoration(this.btndevoluciones, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btndevoluciones, BunifuAnimatorNS.DecorationType.None);
            this.btndevoluciones.Location = new System.Drawing.Point(1455, 216);
            this.btndevoluciones.Name = "btndevoluciones";
            this.btndevoluciones.Size = new System.Drawing.Size(83, 46);
            this.btndevoluciones.TabIndex = 0;
            this.btndevoluciones.Text = "Devoluciones";
            this.btndevoluciones.UseVisualStyleBackColor = true;
            // 
            // txtcodigoproducto
            // 
            this.contraer_menu.SetDecoration(this.txtcodigoproducto, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtcodigoproducto, BunifuAnimatorNS.DecorationType.None);
            this.txtcodigoproducto.Location = new System.Drawing.Point(346, 122);
            this.txtcodigoproducto.Name = "txtcodigoproducto";
            this.txtcodigoproducto.Size = new System.Drawing.Size(127, 20);
            this.txtcodigoproducto.TabIndex = 31;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.expandir_menu.SetDecoration(this.lblcodigo, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblcodigo, BunifuAnimatorNS.DecorationType.None);
            this.lblcodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(232, 124);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(107, 18);
            this.lblcodigo.TabIndex = 30;
            this.lblcodigo.Text = "Código Producto";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.txtdescripcion, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtdescripcion, BunifuAnimatorNS.DecorationType.None);
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Location = new System.Drawing.Point(346, 161);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(250, 20);
            this.txtdescripcion.TabIndex = 24;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.expandir_menu.SetDecoration(this.lbldescripcion, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lbldescripcion, BunifuAnimatorNS.DecorationType.None);
            this.lbldescripcion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.Location = new System.Drawing.Point(232, 161);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(79, 18);
            this.lbldescripcion.TabIndex = 23;
            this.lbldescripcion.Text = "Descripción";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contraer_menu.SetDecoration(this.txtcantidad, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtcantidad, BunifuAnimatorNS.DecorationType.None);
            this.txtcantidad.Location = new System.Drawing.Point(864, 161);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(35, 20);
            this.txtcantidad.TabIndex = 22;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblcantidad
            // 
            this.lblcantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcantidad.AutoSize = true;
            this.expandir_menu.SetDecoration(this.lblcantidad, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblcantidad, BunifuAnimatorNS.DecorationType.None);
            this.lblcantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(790, 161);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(62, 18);
            this.lblcantidad.TabIndex = 21;
            this.lblcantidad.Text = "Cántidad";
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.btnImprimir);
            this.panel4.Controls.Add(this.txtDescuento);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtSubtotal);
            this.panel4.Controls.Add(this.txtImpuesto);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbltotal);
            this.panel4.Controls.Add(this.txttotal);
            this.expandir_menu.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(222, 526);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(978, 126);
            this.panel4.TabIndex = 20;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.expandir_menu.SetDecoration(this.btnCancelar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btnCancelar, BunifuAnimatorNS.DecorationType.None);
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnCancelar.Location = new System.Drawing.Point(882, 47);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::SiguaSportsApp.Properties.Resources.print_printer_tool_with_printed_paper_outlined_symbol_icon_icons_com_57772;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.expandir_menu.SetDecoration(this.btnImprimir, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btnImprimir, BunifuAnimatorNS.DecorationType.None);
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(39, 47);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 53);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuento.BackColor = System.Drawing.Color.White;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraer_menu.SetDecoration(this.txtDescuento, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtDescuento, BunifuAnimatorNS.DecorationType.None);
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(716, 40);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 10;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.expandir_menu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descuento";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.expandir_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotal.BackColor = System.Drawing.Color.White;
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraer_menu.SetDecoration(this.txtSubtotal, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtSubtotal, BunifuAnimatorNS.DecorationType.None);
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(716, 16);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 7;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImpuesto.BackColor = System.Drawing.Color.White;
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraer_menu.SetDecoration(this.txtImpuesto, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtImpuesto, BunifuAnimatorNS.DecorationType.None);
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(716, 65);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtImpuesto.TabIndex = 6;
            this.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.expandir_menu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(662, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISV";
            // 
            // dgvventas
            // 
            this.dgvventas.AllowUserToAddRows = false;
            this.dgvventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvventas.BackgroundColor = System.Drawing.Color.White;
            this.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna_codigo,
            this.columna_descripcion,
            this.columna_precio,
            this.columna_cantidad,
            this.columna_total});
            this.expandir_menu.SetDecoration(this.dgvventas, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dgvventas, BunifuAnimatorNS.DecorationType.None);
            this.dgvventas.Location = new System.Drawing.Point(222, 213);
            this.dgvventas.Name = "dgvventas";
            this.dgvventas.ReadOnly = true;
            this.dgvventas.RowHeadersVisible = false;
            this.dgvventas.RowHeadersWidth = 51;
            this.dgvventas.Size = new System.Drawing.Size(968, 306);
            this.dgvventas.TabIndex = 18;
            // 
            // columna_codigo
            // 
            this.columna_codigo.HeaderText = "Código";
            this.columna_codigo.MinimumWidth = 6;
            this.columna_codigo.Name = "columna_codigo";
            this.columna_codigo.ReadOnly = true;
            this.columna_codigo.Width = 125;
            // 
            // columna_descripcion
            // 
            this.columna_descripcion.HeaderText = "Descripción";
            this.columna_descripcion.MinimumWidth = 220;
            this.columna_descripcion.Name = "columna_descripcion";
            this.columna_descripcion.ReadOnly = true;
            this.columna_descripcion.Width = 280;
            // 
            // columna_precio
            // 
            this.columna_precio.HeaderText = "Precio";
            this.columna_precio.MinimumWidth = 6;
            this.columna_precio.Name = "columna_precio";
            this.columna_precio.ReadOnly = true;
            this.columna_precio.Width = 125;
            // 
            // columna_cantidad
            // 
            this.columna_cantidad.HeaderText = "Cántidad";
            this.columna_cantidad.MinimumWidth = 6;
            this.columna_cantidad.Name = "columna_cantidad";
            this.columna_cantidad.ReadOnly = true;
            this.columna_cantidad.Width = 125;
            // 
            // columna_total
            // 
            this.columna_total.HeaderText = "Total";
            this.columna_total.MinimumWidth = 6;
            this.columna_total.Name = "columna_total";
            this.columna_total.ReadOnly = true;
            this.columna_total.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtp_FechaVenta);
            this.panel2.Controls.Add(this.lblfecha);
            this.panel2.Controls.Add(this.txtvendedor);
            this.panel2.Controls.Add(this.lblvendedor);
            this.panel2.Controls.Add(this.txtfactura);
            this.panel2.Controls.Add(this.lblfactura);
            this.expandir_menu.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(222, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 45);
            this.panel2.TabIndex = 17;
            // 
            // dtp_FechaVenta
            // 
            this.dtp_FechaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expandir_menu.SetDecoration(this.dtp_FechaVenta, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.dtp_FechaVenta, BunifuAnimatorNS.DecorationType.None);
            this.dtp_FechaVenta.Enabled = false;
            this.dtp_FechaVenta.Location = new System.Drawing.Point(768, 13);
            this.dtp_FechaVenta.Name = "dtp_FechaVenta";
            this.dtp_FechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaVenta.TabIndex = 2;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.expandir_menu.SetDecoration(this.lblfecha, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblfecha, BunifuAnimatorNS.DecorationType.None);
            this.lblfecha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(719, 12);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(44, 18);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha";
            // 
            // txtvendedor
            // 
            this.txtvendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtvendedor.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.txtvendedor, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtvendedor, BunifuAnimatorNS.DecorationType.None);
            this.txtvendedor.Location = new System.Drawing.Point(315, 14);
            this.txtvendedor.Name = "txtvendedor";
            this.txtvendedor.ReadOnly = true;
            this.txtvendedor.Size = new System.Drawing.Size(356, 20);
            this.txtvendedor.TabIndex = 2;
            // 
            // lblvendedor
            // 
            this.lblvendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblvendedor.AutoSize = true;
            this.expandir_menu.SetDecoration(this.lblvendedor, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblvendedor, BunifuAnimatorNS.DecorationType.None);
            this.lblvendedor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvendedor.Location = new System.Drawing.Point(243, 13);
            this.lblvendedor.Name = "lblvendedor";
            this.lblvendedor.Size = new System.Drawing.Size(66, 18);
            this.lblvendedor.TabIndex = 2;
            this.lblvendedor.Text = "Vendedor";
            // 
            // txtfactura
            // 
            this.txtfactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtfactura.BackColor = System.Drawing.Color.White;
            this.txtfactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraer_menu.SetDecoration(this.txtfactura, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtfactura, BunifuAnimatorNS.DecorationType.None);
            this.txtfactura.Enabled = false;
            this.txtfactura.Location = new System.Drawing.Point(69, 14);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(133, 20);
            this.txtfactura.TabIndex = 2;
            // 
            // lblfactura
            // 
            this.lblfactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblfactura.AutoSize = true;
            this.expandir_menu.SetDecoration(this.lblfactura, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblfactura, BunifuAnimatorNS.DecorationType.None);
            this.lblfactura.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfactura.Location = new System.Drawing.Point(9, 13);
            this.lblfactura.Name = "lblfactura";
            this.lblfactura.Size = new System.Drawing.Size(55, 18);
            this.lblfactura.TabIndex = 2;
            this.lblfactura.Text = "Factura";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expandir_menu.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(1455, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boton_salir);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.btn_maximizar);
            this.panel1.Controls.Add(this.btn_restaurar);
            this.expandir_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 53);
            this.panel1.TabIndex = 32;
            // 
            // boton_salir
            // 
            this.boton_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.boton_salir, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.boton_salir, BunifuAnimatorNS.DecorationType.None);
            this.boton_salir.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.boton_salir.Location = new System.Drawing.Point(998, 11);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(30, 30);
            this.boton_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_salir.TabIndex = 41;
            this.boton_salir.TabStop = false;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimizar.Image = global::SiguaSportsApp.Properties.Resources.minus__1_;
            this.btn_minimizar.Location = new System.Drawing.Point(926, 11);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 40;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click_1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_maximizar.Image = global::SiguaSportsApp.Properties.Resources.maximize__2_;
            this.btn_maximizar.Location = new System.Drawing.Point(962, 12);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(30, 30);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 37;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.btn_restaurar.Image = global::SiguaSportsApp.Properties.Resources.window_restore;
            this.btn_restaurar.Location = new System.Drawing.Point(962, 11);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(30, 30);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 39;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click_1);
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
            this.contenedor_menu.TabIndex = 33;
            // 
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.btn_logueo);
            this.SideBar.Controls.Add(this.btn_Cambio);
            this.SideBar.Controls.Add(this.btn_Administracion);
            this.SideBar.Controls.Add(this.btn_Devoluciones);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.SideBar.Controls.Add(this.label4);
            this.SideBar.Controls.Add(this.linea_sidebar);
            this.contraer_menu.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
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
            // btn_logueo
            // 
            this.btn_logueo.Activecolor = System.Drawing.Color.Transparent;
            this.btn_logueo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logueo.BackColor = System.Drawing.Color.Transparent;
            this.btn_logueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logueo.BorderRadius = 0;
            this.btn_logueo.ButtonText = "              CERRAR SESIÓN";
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
            this.btn_logueo.Location = new System.Drawing.Point(2, 545);
            this.btn_logueo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_logueo.Name = "btn_logueo";
            this.btn_logueo.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_logueo.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_logueo.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_logueo.selected = false;
            this.btn_logueo.Size = new System.Drawing.Size(206, 42);
            this.btn_logueo.TabIndex = 39;
            this.btn_logueo.Text = "              CERRAR SESIÓN";
            this.btn_logueo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logueo.Textcolor = System.Drawing.Color.White;
            this.btn_logueo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Cambio
            // 
            this.btn_Cambio.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Cambio.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cambio.BorderRadius = 0;
            this.btn_Cambio.ButtonText = "              CAMBIO";
            this.btn_Cambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandir_menu.SetDecoration(this.btn_Cambio, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_Cambio, BunifuAnimatorNS.DecorationType.None);
            this.btn_Cambio.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cambio.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cambio.Iconimage = global::SiguaSportsApp.Properties.Resources.change;
            this.btn_Cambio.Iconimage_right = null;
            this.btn_Cambio.Iconimage_right_Selected = null;
            this.btn_Cambio.Iconimage_Selected = null;
            this.btn_Cambio.IconMarginLeft = 0;
            this.btn_Cambio.IconMarginRight = 0;
            this.btn_Cambio.IconRightVisible = true;
            this.btn_Cambio.IconRightZoom = 0D;
            this.btn_Cambio.IconVisible = true;
            this.btn_Cambio.IconZoom = 85D;
            this.btn_Cambio.IsTab = false;
            this.btn_Cambio.Location = new System.Drawing.Point(4, 184);
            this.btn_Cambio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cambio.Name = "btn_Cambio";
            this.btn_Cambio.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Cambio.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Cambio.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Cambio.selected = false;
            this.btn_Cambio.Size = new System.Drawing.Size(224, 42);
            this.btn_Cambio.TabIndex = 7;
            this.btn_Cambio.Text = "              CAMBIO";
            this.btn_Cambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cambio.Textcolor = System.Drawing.Color.White;
            this.btn_Cambio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cambio.Click += new System.EventHandler(this.btn_Cambio_Click);
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
            this.btn_Administracion.Location = new System.Drawing.Point(4, 119);
            this.btn_Administracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Administracion.Name = "btn_Administracion";
            this.btn_Administracion.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Administracion.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Administracion.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Administracion.selected = false;
            this.btn_Administracion.Size = new System.Drawing.Size(224, 42);
            this.btn_Administracion.TabIndex = 6;
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
            this.expandir_menu.SetDecoration(this.btn_Devoluciones, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_Devoluciones, BunifuAnimatorNS.DecorationType.None);
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
            this.btn_Devoluciones.Location = new System.Drawing.Point(4, 51);
            this.btn_Devoluciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Devoluciones.Name = "btn_Devoluciones";
            this.btn_Devoluciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Devoluciones.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btn_Devoluciones.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Devoluciones.selected = false;
            this.btn_Devoluciones.Size = new System.Drawing.Size(224, 42);
            this.btn_Devoluciones.TabIndex = 5;
            this.btn_Devoluciones.Text = "              DEVOLUCIONES";
            this.btn_Devoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Devoluciones.Textcolor = System.Drawing.Color.White;
            this.btn_Devoluciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Devoluciones.Click += new System.EventHandler(this.btn_Devoluciones_Click);
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
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "SiguaSport";
            // 
            // linea_sidebar
            // 
            this.linea_sidebar.BackColor = System.Drawing.Color.Transparent;
            this.expandir_menu.SetDecoration(this.linea_sidebar, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.linea_sidebar, BunifuAnimatorNS.DecorationType.None);
            this.linea_sidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linea_sidebar.LineThickness = 1;
            this.linea_sidebar.Location = new System.Drawing.Point(3, 40);
            this.linea_sidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linea_sidebar.Name = "linea_sidebar";
            this.linea_sidebar.Size = new System.Drawing.Size(198, 10);
            this.linea_sidebar.TabIndex = 1;
            this.linea_sidebar.Transparency = 255;
            this.linea_sidebar.Vertical = false;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.expandir_menu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "MENÚ";
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
            this.btn_menu.TabIndex = 35;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraer_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.btn_salir, BunifuAnimatorNS.DecorationType.None);
            this.btn_salir.Image = global::SiguaSportsApp.Properties.Resources.close;
            this.btn_salir.Location = new System.Drawing.Point(1318, 11);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(30, 30);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 36;
            this.btn_salir.TabStop = false;
            // 
            // btn_AgregarProd
            // 
            this.btn_AgregarProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.expandir_menu.SetDecoration(this.btn_AgregarProd, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.btn_AgregarProd, BunifuAnimatorNS.DecorationType.None);
            this.btn_AgregarProd.Location = new System.Drawing.Point(910, 161);
            this.btn_AgregarProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AgregarProd.Name = "btn_AgregarProd";
            this.btn_AgregarProd.Size = new System.Drawing.Size(75, 24);
            this.btn_AgregarProd.TabIndex = 38;
            this.btn_AgregarProd.Text = "Agregar";
            this.btn_AgregarProd.UseVisualStyleBackColor = false;
            this.btn_AgregarProd.Click += new System.EventHandler(this.btn_AgregarProd_Click);
            // 
            // lblprecio
            // 
            this.lblprecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblprecio.AutoSize = true;
            this.expandir_menu.SetDecoration(this.lblprecio, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this.lblprecio, BunifuAnimatorNS.DecorationType.None);
            this.lblprecio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(790, 126);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(46, 18);
            this.lblprecio.TabIndex = 25;
            this.lblprecio.Text = "Precio";
            // 
            // txtprecio
            // 
            this.txtprecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprecio.BackColor = System.Drawing.Color.White;
            this.contraer_menu.SetDecoration(this.txtprecio, BunifuAnimatorNS.DecorationType.None);
            this.expandir_menu.SetDecoration(this.txtprecio, BunifuAnimatorNS.DecorationType.None);
            this.txtprecio.Enabled = false;
            this.txtprecio.Location = new System.Drawing.Point(863, 126);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(61, 20);
            this.txtprecio.TabIndex = 26;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.ControlBox = false;
            this.Controls.Add(this.btn_AgregarProd);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contenedor_menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcodigoproducto);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvventas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btndevoluciones);
            this.expandir_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.contraer_menu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boton_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            this.contenedor_menu.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }        

        #endregion
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btndevoluciones;
        private System.Windows.Forms.TextBox txtcodigoproducto;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView dgvventas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_FechaVenta;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox txtvendedor;
        private System.Windows.Forms.Label lblvendedor;
        private System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.Label lblfactura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel contenedor_menu;
        private BunifuAnimatorNS.BunifuTransition expandir_menu;
        private BunifuAnimatorNS.BunifuTransition contraer_menu;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuSeparator linea_sidebar;
        private Bunifu.Framework.UI.BunifuGradientPanel SideBar;
        private Bunifu.Framework.UI.BunifuElipse radio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cambio;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Administracion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Devoluciones;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Button btn_AgregarProd;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_logueo;
        private System.Windows.Forms.PictureBox boton_salir;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_total;
    }
}