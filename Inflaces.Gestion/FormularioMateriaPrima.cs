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
    public partial class FormularioMateriaPrima : Form
    {
        private int idMateriaPrimaEditar;
        public FormularioMateriaPrima()
        {
            InitializeComponent();
        }
        public FormularioMateriaPrima(int idMateriaPrima)
        {
            InitializeComponent();

            idMateriaPrimaEditar = idMateriaPrima;

            MateriaPrimaNegocio negocio = new MateriaPrimaNegocio();
            List<Materia_Prima> materias = negocio.ListarMateriasPrimas();

            Materia_Prima materia = materias.Find(x => x.id_materia_prima == idMateriaPrima);

            if (materia != null)
            {
                textNombre.Text = materia.nombre;
                textDescripcion.Text = materia.descripcion;
                textStock.Text = materia.stock.ToString();

                btnAgregarMateriaPrima.Text = "Modificar materia prima";
            }
        }

        private void btnAgregarMateriaPrima_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            if (!int.TryParse(textStock.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número entero.");
                return;
            }

            if (stock < 5)
            {
                MessageBox.Show("El stock debe ser como mínimo 5.");
                return;
            }

            Materia_Prima materiaPrima = new Materia_Prima
            {
                nombre = textNombre.Text,
                descripcion = textDescripcion.Text,
                stock = stock
            };

            MateriaPrimaNegocio negocio = new MateriaPrimaNegocio();

            if (idMateriaPrimaEditar > 0)
            {
                materiaPrima.id_materia_prima = idMateriaPrimaEditar;

                string resultado = negocio.ModificarMateriaPrima(materiaPrima);

                MessageBox.Show(resultado);
            }
            else
            {
                string resultado = negocio.RegistrarMateriaPrima(materiaPrima);

                MessageBox.Show(resultado);
            }

            textNombre.Clear();
            textDescripcion.Clear();
            textStock.Clear();
        }

        private void btnVerMateriasPrimas_Click(object sender, EventArgs e)
        {
            FormularioListaMateriaPrima formulario = new FormularioListaMateriaPrima();
            formulario.ShowDialog();
        }
    }
}
