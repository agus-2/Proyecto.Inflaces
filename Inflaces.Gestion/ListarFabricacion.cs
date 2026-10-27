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
    public partial class ListarFabricacion : Form
    {
        public ListarFabricacion()
        {
            InitializeComponent();
            CargarCiclos();
        }
        private void CargarCiclos()
        {
            FabricacionNegocio fabricacion = new FabricacionNegocio();
            List<Fabricacion> fabricacions = fabricacion.ListarFabricacion();

            dataGridView1.DataSource = fabricacions;
        }
        private void btnDelCiclo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un ciclo de fabricacion para eliminar.");
                return;
            }

            int idfabricacion = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["id_fabricacion"].Value
            );

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que querés eliminar este ciclo de fabricación?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            FabricacionNegocio fabric= new FabricacionNegocio();
            string respuesta = fabric.EliminarCiclo(idfabricacion);

            MessageBox.Show(respuesta);

            if (respuesta.StartsWith("Éxito"))
            {
                CargarCiclos();
            }
        }
        private void btnModiCiclo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un ciclo de fabricacion para modificar.");
                return;
            }

            Fabricacion cicloSeleccionado =
                (Fabricacion)dataGridView1.SelectedRows[0].DataBoundItem;

            FormularioFabricacion formulario =
                new FormularioFabricacion(cicloSeleccionado);

            formulario.ShowDialog();

            CargarCiclos();
        }
    }
}
