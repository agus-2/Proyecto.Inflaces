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
        private int idDetComproEditar = 0;
        private ComprobanteNegocio negocioComprobante = new ComprobanteNegocio();
        private MateriaPrimaNegocio negocioMatPrima = new MateriaPrimaNegocio();
        public FormularioComprobanteCompraDetalle()
        {
            InitializeComponent();
        }

        public FormularioComprobanteCompraDetalle(DetalleComprobante detalleComprobante)
        {
            InitializeComponent();

            idDetComproEditar = detalleComprobante.id_comprobante;
            txtCantidadCompro.Text = detalleComprobante.cantidad.ToString();
            txtPrecioUnitario.Text = detalleComprobante.precio_unitario.ToString();
            txtSubtotal.Text = detalleComprobante.subtotal.ToString();
        }

        private void btnDetalleADD_Click(object sender, EventArgs e)
        {
            try
            {
                //agarra el texto ingresado y lo empaqueta
                DetalleComprobante detalleEmpaquetado = new DetalleComprobante
                {
                    id_materia_prima = (int)cmboMatPrima.SelectedValue,
                    id_comprobante = idDetComproEditar,
                    cantidad = int.Parse(txtCantidadCompro.Text),
                    precio_unitario = int.Parse(txtPrecioUnitario.Text),
                    subtotal = int.Parse(txtSubtotal.Text),
                };

                //llamo al metodo en la capa de negocio
                ComprobanteNegocio detcomprobante = new ComprobanteNegocio();
                string respuesta;

                if (idDetComproEditar == 0)
                {
                    respuesta = detcomprobante.RegistrarDetComprobante(detalleEmpaquetado);
                }
                else
                {
                    detalleEmpaquetado.id_comprobante = idDetComproEditar;
                    respuesta = detcomprobante.ModificarDetComprobante(detalleEmpaquetado);
                }

                MessageBox.Show(respuesta);

                if (respuesta.StartsWith("Éxito"))
                {
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error" + ex.Message);
            }
        }

        private void FormularioComprobanteCompraDetalle_Load(object sender, EventArgs e)
        {
            CargarMatPrima();
            CargarListaDetComp();
        }
        private void CargarMatPrima(){
            try
            {
                cmboMatPrima.DataSource = negocioMatPrima.ListarMateriasPrimas();
                cmboMatPrima.ValueMember = "id_materia_prima";
                cmboMatPrima.DisplayMember = "Materia Prima";
                cmboMatPrima.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de materia prima: " + ex.Message);
            }
        }
        private void CargarListaDetComp() {
            ComprobanteNegocio comprob = new ComprobanteNegocio();
            List<DetalleComprobante> detComprobantes = comprob.ListarDetComprobante();

            dgvComprobanteDetalle.DataSource = detComprobantes;
        }
        private void LimpiarCampos()
        {
            idDetComproEditar = 0;
            if (cmboMatPrima.Items.Count > 0) cmboMatPrima.SelectedIndex = -1 ;
            txtCantidadCompro.Clear();
            txtPrecioUnitario.Clear();
            txtSubtotal.Clear();
        }
        private void btnDetalleModi_Click(object sender, EventArgs e)
        {
            if (dgvComprobanteDetalle.CurrentRow == null || dgvComprobanteDetalle.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccioná el detalle de un comprobante para modificar.");
                return;
            }

            DetalleComprobante comprobSeleccionado =
                (DetalleComprobante)dgvComprobanteDetalle.CurrentRow.DataBoundItem;

            using (FormularioComprobanteCompraDetalle formulario = new FormularioComprobanteCompraDetalle(comprobSeleccionado))
            { 
                formulario.ShowDialog();
            }

            CargarListaDetComp();
        }
    }
}
