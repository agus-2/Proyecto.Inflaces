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

namespace Inflaces.Gestion
{
    public partial class FormularioComprobanteCompra : Form
    {
        private ComprobanteNegocio negocioComprobante = new ComprobanteNegocio();
        private ProveedorNegocio negocioProveedor = new ProveedorNegocio();

        private int idComprobanteEditar = 0;
        public FormularioComprobanteCompra()
        {
            InitializeComponent();
        }

        private void btnAgregarComprobante_Click(object sender, EventArgs e)
        {
            if (cmboProveedor.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipoComprobante.Text))
            {
                MessageBox.Show("Debe escribir el tipo de comprobante.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNComprobante.Text))
            {
                MessageBox.Show("Debe ingresar el número de comprobante.");
                return;
            }

            if (!decimal.TryParse(txtTotalCompro.Text, out decimal total) || total <= 0)
            {
                MessageBox.Show("Ingrese un monto total válido mayor a 0.");
            }

            Comprobante nuevoComprobante = new Comprobante
            {
                id_proveedor = (int)cmboProveedor.SelectedValue,
                tipo_comprobante = txtTipoComprobante.Text,
                numero_comprobante = txtNComprobante.Text,
                fecha = dtpFecha.Value,
                total = total
            };

            string respuesta = negocioComprobante.AgregarComprobante(nuevoComprobante);
            MessageBox.Show(respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (respuesta.StartsWith("Éxito"))
            {
                CargarListaComprobantes();
                LimpiarCampos();
            }
        }

        private void btnDetaComprobante_Click(object sender, EventArgs e)
        {
            FormularioComprobanteCompraDetalle formulario = new FormularioComprobanteCompraDetalle();
            formulario.ShowDialog();
        }

        private void FormularioComprobanteCompra_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarListaComprobantes();
            LimpiarCampos();
        }
        private void CargarProveedores()
        {
            try
            {
                cmboProveedor.DataSource = negocioProveedor.ListarProveedores();
                cmboProveedor.ValueMember = "id_proveedor";
                cmboProveedor.DisplayMember = "nombre_proveedor";
                // O la propiedad que muestre el nombre/razón social
                cmboProveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaComprobantes()
        {
            try
            {
                dgvComprobantes.DataSource = null;
                dgvComprobantes.DataSource = negocioComprobante.ListarComprobantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar comprobantes");
            }
        }

        private void LimpiarCampos()
        {
            idComprobanteEditar = 0;
            cmboProveedor.SelectedIndex = -1;
            txtTipoComprobante.Clear();
            txtNComprobante.Clear();
            dtpFecha.Value = DateTime.Now;
            txtTotalCompro.Clear();
        }
        private void btnModiComprobante_Click(object sender, EventArgs e)
        {
            if (idComprobanteEditar == 0)
            {
                MessageBox.Show("Seleccione un comprobante de la lista para modificar.");
                return;
            }
            if (!decimal.TryParse(txtTotalCompro.Text, out decimal total) || total <= 0)
            {
                MessageBox.Show("Ingrese un monto total válido mayor a 0.");
                return;
            }
            Comprobante ComprobanteAEditar = new Comprobante
            {
                id_comprobante = idComprobanteEditar,
                id_proveedor = (int)cmboProveedor.SelectedValue,
                tipo_comprobante = txtTipoComprobante.Text,
                numero_comprobante = txtNComprobante.Text,
                fecha = dtpFecha.Value,
                total = total
            };

            string respuesta = negocioComprobante.ModificarComprobante(ComprobanteAEditar);
            MessageBox.Show(respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (respuesta.StartsWith("Éxito"))
            {
                CargarListaComprobantes();
                LimpiarCampos();
            }
        }
    }
}




