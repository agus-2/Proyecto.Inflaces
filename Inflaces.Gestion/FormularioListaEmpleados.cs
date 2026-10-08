using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Inflaces.Gestion
{
    public partial class FormularioListaEmpleados : Form
    {
        private EmpleadoNegocio negocio = new EmpleadoNegocio();

        public FormularioListaEmpleados()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            dataGridView1.DataSource = negocio.ListarEmpleados();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un empleado para modificar.");
                return;
            }

            int idEmpleado = Convert.ToInt32(
                dataGridView1.SelectedRows[0]
                    .Cells["id_empleado"].Value
            );

            FormularioEmpleado formulario =
                new FormularioEmpleado(idEmpleado);

            formulario.ShowDialog();

            CargarEmpleados();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un empleado para eliminar.");
                return;
            }

            int idEmpleado = Convert.ToInt32(
                dataGridView1.SelectedRows[0]
                    .Cells["id_empleado"].Value
            );

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que querés eliminar este empleado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                string mensaje = negocio.EliminarEmpleado(idEmpleado);

                MessageBox.Show(mensaje);

                CargarEmpleados();
            }
        }
    }
}