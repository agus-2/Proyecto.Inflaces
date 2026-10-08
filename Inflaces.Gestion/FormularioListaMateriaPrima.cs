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
    public partial class FormularioListaMateriaPrima : Form
    {
        private MateriaPrimaNegocio negocio = new MateriaPrimaNegocio();

        public FormularioListaMateriaPrima()
        {
            InitializeComponent();
            CargarMateriasPrimas();
        }

        private void CargarMateriasPrimas()
        {
            dataGridView1.DataSource = negocio.ListarMateriasPrimas();
        }

        private void btnModificarMateriaPrima_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná una materia prima para modificar.");
                return;
            }

            int idMateriaPrima = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["id_materia_prima"].Value
            );

            FormularioMateriaPrima formulario =
                new FormularioMateriaPrima(idMateriaPrima);

            formulario.ShowDialog();

            CargarMateriasPrimas();
        }

        private void btnEliminarMateriaPrima_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná una materia prima para eliminar.");
                return;
            }

            int idMateriaPrima = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["id_materia_prima"].Value
            );

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que querés eliminar esta materia prima?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                string mensaje = negocio.EliminarMateriaPrima(idMateriaPrima);

                MessageBox.Show(mensaje);

                CargarMateriasPrimas();
            }
        }
    }
}