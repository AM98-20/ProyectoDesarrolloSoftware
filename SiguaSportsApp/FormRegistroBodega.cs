using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiguaSportsApp
{
    public partial class FormRegistroBodega : Form
    {
        public FormRegistroBodega()
        {
            InitializeComponent();
        }
        private void FormRegistroBodega_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'siguaSportsDataSet.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.siguaSportsDataSet.Proveedores);
            datos.CargarDatosTablas(dgvProductos, query);
            datos.CargarDatosTablas(dgvProveedores, query1);
            datos.CargarDatosCombo(cb_ProveedoresPRB, qCombo);
            datos.CargarDatosCombo(cb_Categoria, qCombo1);
            dtp_Compra.MaxDate = DateTime.Today;
      
        }

        string query = "SELECT cod_producto Codigo, CONCAT(p.nombre, ' ', color,  ' ', marca) Descripcion, " +
            "precioCompra [Precio de Compra], precioVenta [Precio de Venta], c.descripcion Categoria, pr.nombre Proveedor " +
            "FROM Productos p inner join Proveedores pr on p.cod_proveedor = pr.cod_proveedor " +
            "inner join Categorias c on p.cod_categoria = c.cod_categoria";
        string query1 = "Select cod_proveedor Codigo, nombre Nombre, direccion Direccion, telefono Telefono, correo Correo, " +
            "nombre_contacto [Nombre Contacto], telefono_contacto [Telefono Contacto] from Proveedores";
        string qCombo = "SELECT nombre FROM Proveedores";
        string qCombo1 = "SELECT descripcion FROM Categorias";

        ClassDatosTablas datos = new ClassDatosTablas();
        ClassValidacion validacion = new ClassValidacion();
        ClassConexionBD con = new ClassConexionBD();

        bool letra1 = false;
        bool letra2 = false;
        bool letra3 = false;
        bool letra4 = false;
        bool numero1 = false;
        bool numero3 = false;
        bool dinero1 = false;
        bool dinero2 = false;

        private string categoria;
        private string proveedor;

        public void validar()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtcodigoproducto))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtcodigoproducto))
                    ErrorProvider.SetError(txtcodigoproducto, "No se puede dejar en blanco.");
            }
            else
            {
                letra1 = true;
            }            
        }

        public void validar2()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtcantidad) || validacion.Solo_Numeros(ErrorProvider, txtcantidad))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtcantidad))
                    ErrorProvider.SetError(txtcantidad, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Numeros(ErrorProvider, txtcantidad))
                    ErrorProvider.SetError(txtcantidad, "Solo se permiten numeros.");
            }
            else
            {
                numero1 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtFacturaCompra))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtFacturaCompra))
                    ErrorProvider.SetError(txtFacturaCompra, "No se puede dejar en blanco.");
            }
            else
            {
                numero3 = true;
            }            
        }

        public void validar3()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtnombre) || validacion.Solo_Letras(ErrorProvider, txtnombre))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtnombre))
                    ErrorProvider.SetError(txtnombre, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtnombre))
                    ErrorProvider.SetError(txtnombre, "Solo se permiten letras.");
            }
            else
            {
                letra2 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtmarca) || validacion.Solo_Letras(ErrorProvider, txtmarca))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtmarca))
                    ErrorProvider.SetError(txtmarca, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtmarca))
                    ErrorProvider.SetError(txtmarca, "Solo se permiten letras.");
            }
            else
            {
                letra3 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtColor) || validacion.Solo_Letras(ErrorProvider, txtColor))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtColor))
                    ErrorProvider.SetError(txtColor, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtColor))
                    ErrorProvider.SetError(txtColor, "Solo se permiten letras.");
            }
            else
            {
                letra4 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtprecio) || validacion.Solo_Numeros1(ErrorProvider, txtprecio))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtprecio))
                    ErrorProvider.SetError(txtprecio, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Numeros1(ErrorProvider, txtprecio))
                    ErrorProvider.SetError(txtprecio, "Solo se permiten numeros.");
            }
            else
            {
                dinero1 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtPrecioVenta) || validacion.Solo_Numeros1(ErrorProvider, txtPrecioVenta))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtPrecioVenta))
                    ErrorProvider.SetError(txtPrecioVenta, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Numeros1(ErrorProvider, txtPrecioVenta))
                    ErrorProvider.SetError(txtPrecioVenta, "Solo se permiten numeros.");
            }
            else
            {
                dinero2 = true;
            }
        }

        bool letra6 = false;
        bool letra7 = false;
        bool direccion = false;
        bool letra9 = false;
        bool correo = false;
        bool numero6 = false;

        public void validarProveedor()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtCodProveedor) || validacion.Solo_Letras(ErrorProvider, txtCodProveedor))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtCodProveedor))
                    ErrorProvider.SetError(txtCodProveedor, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtCodProveedor))
                    ErrorProvider.SetError(txtCodProveedor, "Solo se permiten letras.");
            }
            else
            {
                letra6 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtNombreProveedor) || validacion.Solo_Letras(ErrorProvider, txtNombreProveedor))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtNombreProveedor))
                    ErrorProvider.SetError(txtNombreProveedor, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtNombreProveedor))
                    ErrorProvider.SetError(txtNombreProveedor, "Solo se permiten letras.");
            }
            else
            {
                letra7 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtDireccionProveedor))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtDireccionProveedor))
                    ErrorProvider.SetError(txtDireccionProveedor, "No se puede dejar en blanco.");
            }
            else
            {
                direccion = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtCorreoProveedor))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtCorreoProveedor))
                    ErrorProvider.SetError(txtCorreoProveedor, "No se puede dejar en blanco.");
            }
            else
            {
                correo = true;
            }

            mtb_TelefonoCon.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (validacion.Espacio_Blanco(ErrorProvider, mtb_TelefonoCon))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, mtb_TelefonoCon))
                    ErrorProvider.SetError(mtb_TelefonoCon, "No se puede dejar en blanco.");
            }
            else
            {
                numero6 = true;
                mtb_TelefonoCon.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtNombreContacto) || validacion.Solo_Letras(ErrorProvider, txtNombreContacto))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtNombreContacto))
                    ErrorProvider.SetError(txtNombreContacto, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Numeros(ErrorProvider, txtNombreContacto))
                    ErrorProvider.SetError(txtNombreContacto, "Solo se permiten numeros.");
            }
            else
            {
                letra9 = true;
            }
        }

        public void Insertar()
        {
            //INSERT a tabla de compras y detalles

            //Compra
            con.cmd = new SqlCommand("INSERT INTO Compras(cod_compra, fecha_compra, descuentoPorcentaje, impuestoPorcentaje, cod_empleado, cod_proveedor) " +
                "values('" + txtFacturaCompra.Text.ToString() + "','" + dtp_Compra.Value.ToShortDateString() + "','0.00'," +
                "'0.15','" + con.Cod_empleado + "','" + proveedor + "')", con.sc);
            try
            {
                con.AbrirConexion();
                con.cmd.ExecuteNonQuery();
                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            //Detalle
            con.cmd = new SqlCommand("INSERT INTO CompraDetalle(cod_compra,cod_producto, cantidad, precioCompra) " +
                "values('" + txtFacturaCompra.Text.ToString() + "','" + txtcodigoproducto.Text.ToString() + "','" + txtcantidad.Text.ToString() + "','" + txtprecio.Text.ToString() + "')", con.sc);
            try
            {
                con.AbrirConexion();
                con.cmd.ExecuteNonQuery();
                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            txtcodigoproducto.Text = "";
            txtnombre.Text = "";
            txtmarca.Text = "";
            txtColor.Text = "";
            txtcantidad.Text = "";
            txtprecio.Text = "";
            txtPrecioVenta.Text = "";
            cb_Categoria.SelectedIndex = -1;
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            letra6 = false; letra7 = false; direccion = false; letra9 = false; correo = false; numero6 = false;

            validarProveedor();
            if (letra6 && letra7 && direccion && letra9 && correo && numero6)
            {
                string nMensaje = "";
                con.sql = string.Format("if exists(select cod_proveedor from Proveedores " +
                    "where cod_proveedor = '"+txtCodProveedor.Text.ToString()+"') begin " +
                    "select 'Ya existe' Mensaje end else begin select 'Nuevo' Mensaje end");
                con.cmd = new SqlCommand(con.sql, con.sc);
                con.AbrirConexion();
                SqlDataReader mensaje = con.cmd.ExecuteReader();
                if (mensaje.Read())
                {
                    nMensaje = mensaje["Mensaje"].ToString();
                }
                con.CerrarConexion();

                if (nMensaje == "Nuevo")
                {
                    con.sql = string.Format("insert into Proveedores(cod_proveedor, nombre, direccion, " +
                        "telefono, correo, nombre_contacto, telefono_contacto) " +
                        "values('"+txtCodProveedor.Text.ToString()+"','"+txtNombreProveedor.Text.ToString()+"'," +
                        "'"+txtDireccionProveedor.Text.ToString()+"','"+mtb_TelefonoPro.Text.ToString()+"'," +
                        "'"+txtCorreoProveedor.Text.ToString()+"','"+txtNombreContacto.Text.ToString()+"'," +
                        "'"+ mtb_TelefonoCon.Text.ToString()+"')");
                    con.AbrirConexion();
                    con.cmd = new SqlCommand(con.sql, con.sc);
                    con.cmd.ExecuteNonQuery();
                    con.CerrarConexion();
                    datos.CargarDatosTablas(dgvProveedores, query1);

                    txtCodProveedor.Text = "";
                    txtNombreProveedor.Text = "";
                    txtDireccionProveedor.Text = "";
                    txtCorreoProveedor.Text = "";
                    txtNombreContacto.Text = "";

                }
                else
                {
                    MessageBox.Show("ERROR. "+nMensaje+" el proveedor.", "Proveedor exixtente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (SideBar.Width == 204)
            {
                SideBar.Visible = false;
                SideBar.Width = 52;
                contenedor_menu.Width = 82;
                linea_sidebar.Width = 48;
                contraer_menu.Show(SideBar);
            }
            else
            {
                SideBar.Visible = false;
                SideBar.Width = 204;
                contenedor_menu.Width = 222;
                linea_sidebar.Width = 198;
                expandir_menu.Show(SideBar);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            boton_restaurar.Visible = true;
        }

        private void btn_Inventario_bodega_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventarioBodega InvBo = new FormInventarioBodega();
            InvBo.ShowDialog();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtCorreoProveedor.Text = "";
            mtb_TelefonoPro.Text = "";
            txtDireccionProveedor.Text = "";
            txtNombreContacto.Text = "";
            mtb_TelefonoCon.Text = "";
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReportes rep = new FormReportes();
            rep.ShowDialog();
            this.Close();
        }

        private void btn_logueo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngreso ing = new FormIngreso();
            ing.ShowDialog();
            this.Close();
        }

        private void boton_restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            boton_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_Administracion_Click(object sender, EventArgs e)
        {
            if (datos.CodigoPuesto == 1)
            {
                this.Hide();
                FormAdministracion adm = new FormAdministracion();
                adm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado. Solo los administradores pueden acceder.", "Acceso Restringido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            string nMensaje = "";
            letra1 = false;
            validar();
            if (letra1)
            {
                con.sql = string.Format("if exists(select cod_producto from Productos where cod_producto = '" + txtcodigoproducto.Text.ToString() + "') begin select 'Ya existe el producto. Desea actualizar la cantidad en existencia?' Mensaje end else begin select 'Nuevo producto' Mensaje end");
                con.cmd = new SqlCommand(con.sql, con.sc);
                try
                {
                    con.AbrirConexion();                    
                    SqlDataReader mensaje = con.cmd.ExecuteReader();
                    if (mensaje.Read())
                    {
                        nMensaje = mensaje["Mensaje"].ToString();
                    }
                    con.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex);
                }

                if (nMensaje == "Nuevo producto")
                {
                    txtnombre.Enabled = true;
                    txtmarca.Enabled = true;
                    txtColor.Enabled = true;
                    txtPrecioVenta.Enabled = true;

                    letra2 = false; letra3 = false; letra4 = false; numero1 = false; numero3 = false; dinero1 = false; dinero2 = false;
                    validar2();
                    validar3();
                    if (letra2 && letra3 && letra4 && numero1 && numero3 && dinero1 && dinero2)
                    {
                        if (cb_Categoria.SelectedIndex != -1 && cb_ProveedoresPRB.SelectedIndex != -1)
                        {                                               
                            con.sql = string.Format("select cod_proveedor from Proveedores pr where nombre = '"+cb_ProveedoresPRB.SelectedItem.ToString()+"'");
                            con.cmd = new SqlCommand(con.sql, con.sc);
                            try
                            {
                                con.AbrirConexion();
                                SqlDataReader lector = con.cmd.ExecuteReader();
                                if (lector.Read())
                                {
                                    proveedor = lector["cod_proveedor"].ToString();
                                }
                                con.CerrarConexion();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR " + ex);
                            }

                            con.sql = string.Format("select cod_categoria from Categorias where descripcion = '"+cb_Categoria.SelectedItem.ToString()+"'");
                            con.cmd = new SqlCommand(con.sql, con.sc);
                            try
                            {
                                con.AbrirConexion();
                                SqlDataReader lector1 = con.cmd.ExecuteReader();
                                if (lector1.Read())
                                {
                                    categoria = lector1["cod_categoria"].ToString();
                                }
                                con.CerrarConexion();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR " + ex);
                            }

                            //INSERT tabla de Productos
                            con.cmd = new SqlCommand("INSERT INTO Productos(cod_producto, nombre, precioVenta, precioCompra, color, marca, existencia, cod_categoria, " +
                                "cod_proveedor) values('" + txtcodigoproducto.Text.ToString() + "', '" + txtnombre.Text.ToString() + "', " +
                                "'" + txtPrecioVenta.Text.ToString() + "','" + txtprecio.Text.ToString() + "','" + txtColor.Text.ToString() + "'," +
                                "'" + txtmarca.Text.ToString() + "','"+txtcantidad.Text.ToString()+"', '" + categoria + "','" + proveedor + "')", con.sc);
                            try
                            {
                                con.AbrirConexion();
                                con.cmd.ExecuteNonQuery();
                                con.CerrarConexion();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR " + ex);
                            }
                            MessageBox.Show("Datos Ingresados.", "Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            datos.CargarDatosTablas(dgvProductos, query);

                            Insertar();
                            txtcodigoproducto.Text = "";
                            txtnombre.Text = "";
                            txtmarca.Text = "";
                            txtColor.Text = "";
                            txtcantidad.Text = "";
                            txtprecio.Text = "";
                            txtPrecioVenta.Text = "";
                            cb_Categoria.SelectedIndex = -1;
                            cb_ProveedoresPRB.SelectedIndex = -1;
                        }
                        else
                        {
                            if (cb_ProveedoresPRB.SelectedIndex == -1)
                                ErrorProvider.SetError(cb_ProveedoresPRB, "Seleccione una opcion.");
                            if (cb_Categoria.SelectedIndex == -1)
                                ErrorProvider.SetError(cb_Categoria, "Seleccione una opcion.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR validacion 1 y 2");
                    }                   
                }
                else 
                {
                    DialogResult result = MessageBox.Show(nMensaje, "Producto Existente",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        numero1 = false; numero3 = false;
                        validar2();
                        if (numero1 && numero3)
                        {
                            if (cb_ProveedoresPRB.SelectedIndex != -1)
                            {
                                try
                                {
                                    con.cmd = new SqlCommand("UPDATE Productos set existencia = (Select existencia from Productos where cod_producto = '" + txtcodigoproducto.Text.ToString() + "') + '" + txtcantidad.Text.ToString() + "' where cod_producto = '" + txtcodigoproducto.Text.ToString() + "'", con.sc);
                                    con.AbrirConexion();
                                    con.cmd.ExecuteNonQuery();
                                    con.CerrarConexion();
                                    datos.CargarDatosTablas(dgvProductos, query);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("ERROR " + ex);
                                }

                                Insertar();
                                txtcodigoproducto.Text = "";
                                txtnombre.Text = "";
                                txtmarca.Text = "";
                                txtColor.Text = "";
                                txtcantidad.Text = "";
                                txtprecio.Text = "";
                                txtPrecioVenta.Text = "";
                                cb_Categoria.SelectedIndex = -1;
                            }
                            else
                            {
                                if(cb_ProveedoresPRB.SelectedIndex == -1)
                                    ErrorProvider.SetError(cb_ProveedoresPRB, "Seleccione una opcion.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR");
            }            
        }
    }
}
