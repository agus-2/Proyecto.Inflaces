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
    public partial class FormularioListaClientes : Form
    {
        public FormularioListaClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            List<Clientes> clientes = negocio.ListarClientes();

            dataGridView1.DataSource = clientes;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un cliente para eliminar.");
                return;
            }
            int idCliente = Convert.ToInt32(
    dataGridView1.SelectedRows[0].Cells["id_cliente"].Value
);
            DialogResult resultado = MessageBox.Show(
    "¿Estás seguro de que querés eliminar este cliente?",
    "Confirmar eliminación",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning
);

            if (resultado != DialogResult.Yes)
            {
                return;
            }
            ClienteNegocio negocio = new ClienteNegocio();
            string respuesta = negocio.EliminarCliente(idCliente);

            MessageBox.Show(respuesta);

            if (respuesta.StartsWith("Éxito"))
            {
                CargarClientes();
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un cliente para modificar.");
                return;
            }

            Clientes clienteSeleccionado = (Clientes)dataGridView1.SelectedRows[0].DataBoundItem;
            FormularioCliente formulario = new FormularioCliente(clienteSeleccionado);
            formulario.ShowDialog();
            CargarClientes();
        }
    }
}
