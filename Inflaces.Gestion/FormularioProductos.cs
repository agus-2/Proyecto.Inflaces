using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Inflaces.Gestion
{
    public partial class FormularioProducto : Form
    {
        private int idProductoEditar = 0;

        public FormularioProducto()
        {
            InitializeComponent();
        }

        public FormularioProducto(Productos producto)
        {
            InitializeComponent();

            idProductoEditar = producto.id_producto;

            textNombre.Text = producto.nombre;
            textDescripcion.Text = producto.descripcion;
            textTalle.Text = producto.talle.ToString();
            textPrecio.Text = producto.precio.ToString();
            textStock.Text = producto.stock.ToString();

            btnAgregarProducto.Text = "Modificar producto";
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Productos productoEmpaquetado = new Productos
                {
                    nombre = textNombre.Text,
                    descripcion = textDescripcion.Text,
                    talle = int.Parse(textTalle.Text),
                    precio = decimal.Parse(textPrecio.Text),
                    stock = int.Parse(textStock.Text)
                };

                ProductoNegocio negocio = new ProductoNegocio();
                string respuesta;

                if (idProductoEditar == 0)
                {
                    respuesta = negocio.RegistrarProducto(productoEmpaquetado);
                }
                else
                {
                    productoEmpaquetado.id_producto = idProductoEditar;
                    respuesta = negocio.ModificarProducto(productoEmpaquetado);
                }

                MessageBox.Show(respuesta);

                if (respuesta.StartsWith("Éxito"))
                {
                    if (idProductoEditar != 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        LimpiarCampos();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Revisá los campos Talle, Precio y Stock: deben contener números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FormularioListaProductos formulario =
                new FormularioListaProductos();

            formulario.ShowDialog();
        }

        private void LimpiarCampos()
        {
            textNombre.Clear();
            textDescripcion.Clear();
            textTalle.Clear();
            textPrecio.Clear();
            textStock.Clear();
        }
    }
}