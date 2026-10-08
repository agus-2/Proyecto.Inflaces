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
    public partial class FormularioListaProductos : Form
    {
        private ProductoNegocio negocio = new ProductoNegocio();

        public FormularioListaProductos()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                List<Productos> lista = negocio.ListarProductos();

                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al cargar los productos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un producto para modificar.");
                return;
            }

            Productos productoSeleccionado =
                (Productos)dataGridView1.CurrentRow.DataBoundItem;

            FormularioProducto formulario =
                new FormularioProducto(productoSeleccionado);

            formulario.ShowDialog();

            CargarProductos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un producto para eliminar.");
                return;
            }

            Productos productoSeleccionado =
                (Productos)dataGridView1.CurrentRow.DataBoundItem;

            DialogResult resultado = MessageBox.Show(
                "¿Estás segura de que querés eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                string respuesta =
                    negocio.EliminarProducto(productoSeleccionado.id_producto);

                MessageBox.Show(respuesta);

                if (respuesta.StartsWith("Éxito"))
                {
                    CargarProductos();
                }
            }
        }
    }
}