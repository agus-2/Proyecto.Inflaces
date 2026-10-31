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
    public partial class FormularioProductoMatPrima : Form
    {
        private int idProdMatPrimaEditar = 0;

        private ProductoMatPrimaNegocio negocioProdMatPrima = new ProductoMatPrimaNegocio();
        private MateriaPrimaNegocio negocioMatPrima = new MateriaPrimaNegocio();
        private ProductoNegocio negocioProducto = new ProductoNegocio();

        public FormularioProductoMatPrima()
        {
            InitializeComponent();
        }

        private void FormularioProductoMatPrima_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarMatPrima();
            CargarPrdMatPrima();
        }
        private void CargarProductos()
        {
            try
            {
                cmboProducto.DataSource = negocioProducto.ListarProductos();
                cmboProducto.DisplayMember = "nombre"; 
                cmboProducto.ValueMember = "id_producto";
                cmboProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de productos: " + ex.Message);
            }
        }
        private void CargarMatPrima()
        {
            try
            {
                cmboMatPrima.DataSource = negocioMatPrima.ListarMateriasPrimas();
                cmboMatPrima.DisplayMember = "nombre";
                cmboMatPrima.ValueMember = "id_materia_prima";
                cmboMatPrima.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de materias primas: " + ex.Message);
            }
        }
        private void CargarPrdMatPrima()
        {

            ProductoMatPrimaNegocio prodMatPrima = new ProductoMatPrimaNegocio();
            List<ProductoMatPrima> prodMatPri = prodMatPrima.ListarProdMatPrima();

            dgvProductoMatPrima.DataSource = prodMatPri;
        }
        private void btnProduMatAdd_Click_1(object sender, EventArgs e)
        {
            if (cmboProducto.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }
            if (cmboMatPrima.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una materia prima");
                return;
            }
            try
            {
                ProductoMatPrima prodMatEmpaquetada = new ProductoMatPrima
                {
                    id_producto = (int)cmboProducto.SelectedValue,
                    id_materia_prima = (int)cmboMatPrima.SelectedValue,
                    cantidad_necesaria = int.Parse(txtCantNecesaria.Text)
                };

                ProductoMatPrimaNegocio prodMat = new ProductoMatPrimaNegocio();
                string respuesta = prodMat.AgregarItem(prodMatEmpaquetada);

                MessageBox.Show(respuesta);

                if (respuesta.StartsWith("Éxito") && idProdMatPrimaEditar != 0)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        private void btnProduMatDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductoMatPrima.CurrentRow == null || dgvProductoMatPrima.CurrentRow.DataBoundItem == null)
                { 
                    MessageBox.Show("Seleccione un ítem de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                } 
                ProductoMatPrima itemSeleccionado = (ProductoMatPrima)dgvProductoMatPrima.CurrentRow.DataBoundItem;
                
                DialogResult confirmacion = MessageBox.Show( "¿Está seguro de quitar esta relacion de materia prima-producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (confirmacion == DialogResult.Yes)
                { 
                    string respuesta = negocioProdMatPrima.EliminarItem(itemSeleccionado);
                    MessageBox.Show(respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if (respuesta.StartsWith("Éxito"))
                    { 
                        CargarPrdMatPrima();
                    } 
                } 
            } 
            catch (Exception ex)
            { 
                MessageBox.Show("Error al eliminar el ítem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmboMatPrima_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }