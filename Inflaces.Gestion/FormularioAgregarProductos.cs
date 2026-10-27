using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Inflaces.Gestion
{
    public partial class FormularioAgregarProductos : Form
    {
        private PedidoNegocio negocioPedido = new PedidoNegocio();
        private Pedidos pedidoActual;
        private ProductoNegocio negocioProducto = new ProductoNegocio();
        // CONSTRUCTOR: Recibe el objeto Pedidos desde el formulario principal

        public FormularioAgregarProductos(Pedidos pedidosRecibido)
        {
            InitializeComponent();
            pedidoActual = pedidosRecibido;
        }

        private void FormularioAgregarProductos_Load(object sender, EventArgs e)
        {
            // Mostramos los datos básicos del pedido en la pantalla
            CargarPedidoProducto();
            CargarProductos();
        }

        //Carga los productos que ya contiene este pedido en el DataGridView
        private void CargarPedidoProducto()
        {
            dgvDetalle.DataSource = negocioPedidoProducto.ListarPedidoProducto();
        }
        private void CargarProductos() {
            try {
                ProductoNegocio negocio = new ProductoNegocio();
                cboProducto.DataSource = negocio.ListarProductos();
                cboProducto.ValueMember = "id_producto";
                cboProducto.DisplayMember = "nombre";
                cboProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los productos: " + ex.Message);
            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem != null)
            {
                Productos prod = (Productos)cboProducto.SelectedItem;
                txtPrecioUnitario.Text = prod.precio.ToString("N2");
                CalcularSubtotal();
            }
            else {
                txtPrecioUnitario.Clear();
                txtSubtotal.Clear();
            }
        }
        // 4\. Recalcula el subtotal si cambia la cantidad
        private void nupCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }
        private void CalcularSubtotal()
        {
            if (decimal.TryParse(txtPrecioUnitario.Text, out decimal precio))
            {
                int cantidad = Convert.ToInt32(nupCantidad.Value);
                txtSubtotal.Text = (cantidad * precio).ToString("N2");
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try {
                if (cboProducto.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un producto.");
                    return;
                }

                if (nupCantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0.");
                    return;
                }
                // Empaquetamos el nuevo producto asociado al id\_pedido recibido

                PedidoProducto nuevoDetalle = new PedidoProducto
                {
                    id_pedido = pedidoActual.id_pedido,
                    id_producto = (int)cboProducto.SelectedValue,
                    cantidad = Convert.ToInt32(nupCantidad.Value),
                    precio_unitario = decimal.Parse(txtPrecioUnitario.Text),
                };

                // Guardar en la BD
                string respuesta = negocioPedido.RegistrarProductoEnPedido(nuevoDetalle);
                MessageBox.Show(respuesta);
                if (respuesta.StartsWith("Éxito"))
                {
                    CargarGrillaDetalle(); // Refresca la tabla del formulario
                    LimpiarCampos();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar: " + ex.Message); }
        }

        // 6\. ACCIÓN: ELIMINAR UN PRODUCTO ESPECÍFICO DEL PEDIDO
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalle.CurrentRow == null || dgvDetalle.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("Seleccione un producto de la tabla para eliminar.");
                    return;
                }

                PedidoProducto productoSeleccionado = (PedidoProducto)dgvDetalle.CurrentRow.DataBoundItem;
                DialogResult result = MessageBox.Show(
                    $"¿Desea quitar '{productoSeleccionado.nombre_producto}' de este pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string respuesta = negocioPedido.EliminarProductoDePedido(

                        pedidoActual.id_pedido, productoSeleccionado.id_producto);

                    MessageBox.Show(respuesta);

                    if (respuesta.StartsWith("Éxito"))
                    { CargarGrillaDetalle(); // Refresca la tabla tras la eliminación
                    }
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al eliminar el producto: " + ex.Message); 
            } 
        }
        private void LimpiarCampos()
        {
            cboProducto.SelectedIndex = -1;
            txtPrecioUnitario.Clear();
            txtSubtotal.Clear();
            nupCantidad.Value = 1;
        }

        }
    }










