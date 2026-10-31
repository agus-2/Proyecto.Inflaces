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
    public partial class FormularioPedidos : Form
    {
        private PedidoNegocio negocioPedido = new PedidoNegocio();
        private ClienteNegocio negocioCliente = new ClienteNegocio();
        private int idPedidoEditar = 0;
        public FormularioPedidos()
        {
            InitializeComponent();
        }
        private void FormularioPedidos_Load(object sender, EventArgs e)
        {
            CargarListaPedidos();
            CargarClientes();
            CargarEstados();
        }
        private void CargarListaPedidos()
        {
            try
            {
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = negocioPedido.ListarPedidos();

                dgvPedidos.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar lista de pedidos: " + ex.Message);
            }
        }
        private void CargarClientes() {
            try
            {
                cmbxClientePedido.DataSource = negocioCliente.ListarClientes();
                cmbxClientePedido.ValueMember = "id_cliente";
                cmbxClientePedido.DisplayMember = "Nombre_Completo";
                cmbxClientePedido.SelectedIndex = -1;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }
        private void CargarEstados()
        {
            cmbxEstPedido.Items.Clear();
            cmbxEstPedido.Items.AddRange(new String[] { "Pendiente", "En Proceso", "Para Despachar", "Entregado", "Cancelado"});
            cmbxEstPedido.SelectedIndex = 0;
        }
        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            try
            {
                //valida seleccion
                if (cmbxClientePedido.SelectedValue == null || Convert.ToInt32(cmbxClientePedido.SelectedValue) <= 0) {
                    MessageBox.Show("Debe seleccionar un cliente para crear el pedido.");
                    return;
                }
                //agarra el texto ingresado y lo empaqueta
                Pedidos pedidoEmpaquetado = new Pedidos()
                {
                    fecha_pedido = dtpPedido.Value,
                    id_cliente = (int)cmbxClientePedido.SelectedValue,
                    estado = cmbxEstPedido.SelectedItem.ToString(),
                    total = 0 //inicia en 0 hasta que se carguen productos
                };

                string respuesta = negocioPedido.RegistrarPedido(pedidoEmpaquetado);
                MessageBox.Show(respuesta);

                if (respuesta.StartsWith("Éxito"))
                {
                    CargarListaPedidos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error" + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            idPedidoEditar = 0;
            dtpPedido.Value = DateTime.Now;
            if (cmbxClientePedido.Items.Count > 0)
            {
                cmbxClientePedido.SelectedIndex = -1;
            } 
        }
        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null) 
            { 
                MessageBox.Show("Seleccione un pedido para eliminar.");
                 return; 
            }
            Pedidos pedidoSeleccionado = (Pedidos)dgvPedidos.CurrentRow.DataBoundItem;
            
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de eliminar el pedido N° {pedidoSeleccionado.id_pedido} y todos sus productos?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning); 
            
            if (confirmacion == DialogResult.Yes) 
            { 
                string respuesta = negocioPedido.EliminarPedidoCompleto(pedidoSeleccionado.id_pedido);
                MessageBox.Show(respuesta);
                
                if (respuesta.StartsWith("Éxito")) 
                { 
                    CargarListaPedidos(); 
                
                } 
            }
        }
        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido de la lista para gestionar sus productos.");
                return; 
            }
            Pedidos pedidoSeleccionado = (Pedidos)dgvPedidos.CurrentRow.DataBoundItem;
            // Abrimos el formulario de detalle enviándole el pedido seleccionado
            FormularioAgregarProductos formularioAgregar = new FormularioAgregarProductos(pedidoSeleccionado);
                formularioAgregar.ShowDialog();

                CargarListaPedidos();
        }
        private void btnModificarEstado_Click(object sender, EventArgs e)
        {
            if(dgvPedidos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido de la tabla.");
                return;
            }
            Pedidos pedidoSeleccionado = (Pedidos)dgvPedidos.CurrentRow.DataBoundItem;
            string nuevoEstado = cmbxEstPedido.SelectedItem.ToString();

            string respuesta = negocioPedido.ActualizarEstadoPedido(pedidoSeleccionado, nuevoEstado);
            MessageBox.Show(respuesta);

            if (respuesta.Contains("Éxito"))
            {
                CargarListaPedidos();
            }
        }
    }
}
