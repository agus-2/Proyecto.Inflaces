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
    public partial class FormularioListaProveedores : Form
    {
        public FormularioListaProveedores()
        {
            InitializeComponent();
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            ProveedorNegocio negocio = new ProveedorNegocio();
            List<Proveedores> proveedores = negocio.ListarProveedores();

            dataGridView1.DataSource = proveedores;
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un proveedor para eliminar.");
                return;
            }

            int idProveedor = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["id_proveedor"].Value
            );

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que querés eliminar este proveedor?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            ProveedorNegocio negocio = new ProveedorNegocio();
            string respuesta = negocio.EliminarProveedor(idProveedor);

            MessageBox.Show(respuesta);

            if (respuesta.StartsWith("Éxito"))
            {
                CargarProveedores();
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un proveedor para modificar.");
                return;
            }

            Proveedores proveedorSeleccionado =
                (Proveedores)dataGridView1.SelectedRows[0].DataBoundItem;

            FormularioProveedor formulario =
                new FormularioProveedor(proveedorSeleccionado);

            formulario.ShowDialog();

            CargarProveedores();
        }
    }
}