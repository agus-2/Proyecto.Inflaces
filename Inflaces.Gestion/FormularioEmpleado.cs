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
    public partial class FormularioEmpleado : Form
    {
        private int idEmpleadoEditar;

        public FormularioEmpleado()
        {
            InitializeComponent();

            comboPuesto.Items.Add("Gerente");
            comboPuesto.Items.Add("Supervisor");
            comboPuesto.Items.Add("Fabricacion");
            comboPuesto.Items.Add("Administracion");
        }

        public FormularioEmpleado(int idEmpleado)
        {
            InitializeComponent();

            idEmpleadoEditar = idEmpleado;

            comboPuesto.Items.Add("Gerente");
            comboPuesto.Items.Add("Supervisor");
            comboPuesto.Items.Add("Fabricacion");
            comboPuesto.Items.Add("Administracion");

            EmpleadoNegocio negocio = new EmpleadoNegocio();
            List<Empleados> empleados = negocio.ListarEmpleados();

            Empleados empleado = empleados.Find(
                x => x.id_empleado == idEmpleado
            );

            if (empleado != null)
            {
                textNombre.Text = empleado.nombre;
                textApellido.Text = empleado.apellido;
                textDNI.Text = empleado.dni.ToString();
                textTelefono.Text = empleado.telefono;
                comboPuesto.Text = empleado.puesto;
                textUsuario.Text = empleado.usuario;
                textContraseña.Text = empleado.contraseña;

                btnAgregarEmpleado.Text = "Modificar empleado";
            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.");
                return;
            }

            if (!int.TryParse(textDNI.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número entero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboPuesto.Text))
            {
                MessageBox.Show("Seleccioná un puesto.");
                return;
            }

            // Los puestos con acceso al sistema necesitan usuario y contraseña.
            if ((comboPuesto.Text == "Gerente" ||
                 comboPuesto.Text == "Supervisor") &&
                (string.IsNullOrWhiteSpace(textUsuario.Text) ||
                 string.IsNullOrWhiteSpace(textContraseña.Text)))
            {
                MessageBox.Show(
                    "Los Gerentes y Supervisores deben tener usuario y contraseña."
                );
                return;
            }

            Empleados empleado = new Empleados
            {
                nombre = textNombre.Text,
                apellido = textApellido.Text,
                dni = dni,
                telefono = textTelefono.Text,
                puesto = comboPuesto.Text,
                usuario = textUsuario.Text,
                contraseña = textContraseña.Text
            };

            EmpleadoNegocio negocio = new EmpleadoNegocio();

            if (idEmpleadoEditar > 0)
            {
                empleado.id_empleado = idEmpleadoEditar;

                string resultado = negocio.ModificarEmpleado(empleado);

                MessageBox.Show(resultado);
            }
            else
            {
                string resultado = negocio.RegistrarEmpleado(empleado);

                MessageBox.Show(resultado);
            }

            textNombre.Clear();
            textApellido.Clear();
            textDNI.Clear();
            textTelefono.Clear();
            comboPuesto.SelectedIndex = -1;
            textUsuario.Clear();
            textContraseña.Clear();
        }

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            FormularioListaEmpleados formulario =
                new FormularioListaEmpleados();

            formulario.ShowDialog();
        }
    }
}
