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
    public partial class FormularioComprobanteCompraDetalle : Form
    {
        private int idComprobante = 0;
        private bool modoEdicion = false;
        private int idMateriaPrimaOriginal = 0;
        private ComprobanteNegocio negocioComprobante = new ComprobanteNegocio();
        private MateriaPrimaNegocio negocioMatPrima = new MateriaPrimaNegocio();
        public FormularioComprobanteCompraDetalle()
        {
            InitializeComponent();
        }

        public FormularioComprobanteCompraDetalle(int idComprobante)
        {
            InitializeComponent();
            this.idComprobante = idComprobante;
        }

        public FormularioComprobanteCompraDetalle(DetalleComprobante detalleComprobante)
        {
            InitializeComponent();

            idComprobante = detalleComprobante.id_comprobante;
            idMateriaPrimaOriginal = detalleComprobante.id_materia_prima;
            modoEdicion = true;

            txtCantidadCompro.Text = detalleComprobante.cantidad.ToString();
            txtPrecioUnitario.Text = detalleComprobante.precio_unitario.ToString();
            txtSubtotal.Text = detalleComprobante.subtotal.ToString();
        }


        private void btnDetalleADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (idComprobante <= 0)
                {
                    MessageBox.Show("Debe seleccionar un comprobante de compra.");
                    return;
                }

                if (cmboMatPrima.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una materia prima.");
                    return;
                }

                if (!int.TryParse(txtCantidadCompro.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida mayor a cero.");
                    return;
                }

                if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Ingrese un precio unitario válido mayor a cero.");
                    return;
                }

                if (!decimal.TryParse(txtSubtotal.Text, out decimal subtotal) || subtotal <= 0)
                {
                    MessageBox.Show("Ingrese un subtotal válido mayor a cero.");
                    return;
                }

                DetalleComprobante detalleEmpaquetado = new DetalleComprobante
                {
                    id_comprobante = idComprobante,
                    id_materia_prima = Convert.ToInt32(cmboMatPrima.SelectedValue),
                    cantidad = cantidad,
                    precio_unitario = precio,
                    subtotal = subtotal
                };

                string respuesta;

                if (modoEdicion)
                {
                    respuesta = negocioComprobante.ModificarDetComprobante(detalleEmpaquetado);
                }
                else
                {
                    respuesta = negocioComprobante.RegistrarDetComprobante(detalleEmpaquetado);
                }

                MessageBox.Show(respuesta);

                if (respuesta.StartsWith("Éxito") ||
                    respuesta.StartsWith("Detalle de comprobante modificado correctamente"))
                {
                    CargarListaDetComp();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void FormularioComprobanteCompraDetalle_Load(object sender, EventArgs e)
        {
            CargarMatPrima();
            CargarListaDetComp();
        }
        private void CargarMatPrima()
        {
            try
            {
                cmboMatPrima.DataSource = negocioMatPrima.ListarMateriasPrimas();
                cmboMatPrima.ValueMember = "id_materia_prima";
                cmboMatPrima.DisplayMember = "Materia Prima";
                cmboMatPrima.SelectedIndex = -1;

                if (modoEdicion)
                {
                    cmboMatPrima.SelectedValue = idMateriaPrimaOriginal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de materia prima: " + ex.Message);
            }
        }

        private void CargarListaDetComp()
        {
            if (idComprobante <= 0)
                return;

            List<DetalleComprobante> detalles =
                negocioComprobante.ListarDetComprobante(idComprobante);

            dgvComprobanteDetalle.DataSource = null;
            dgvComprobanteDetalle.DataSource = detalles;
        }

        private void LimpiarCampos()
        {
            modoEdicion = false;
            idMateriaPrimaOriginal = 0;

            if (cmboMatPrima.Items.Count > 0)
                cmboMatPrima.SelectedIndex = -1;

            txtCantidadCompro.Clear();
            txtPrecioUnitario.Clear();
            txtSubtotal.Clear();
        }
        private void btnDetalleModi_Click(object sender, EventArgs e)
        {
            if (dgvComprobanteDetalle.CurrentRow == null ||
                dgvComprobanteDetalle.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccioná un detalle para modificar.");
                return;
            }

            DetalleComprobante detalleSeleccionado =
                (DetalleComprobante)dgvComprobanteDetalle.CurrentRow.DataBoundItem;

            using (FormularioComprobanteCompraDetalle formulario =
                   new FormularioComprobanteCompraDetalle(detalleSeleccionado))
            {
                formulario.ShowDialog();
            }

            CargarListaDetComp();
        }
    }
}
