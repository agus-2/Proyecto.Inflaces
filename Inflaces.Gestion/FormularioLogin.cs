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
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textUsuario.Text))
            {
                MessageBox.Show("Ingresá el usuario.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textContraseña.Text))
            {
                MessageBox.Show("Ingresá la contraseña.");
                return;
            }

            EmpleadoNegocio negocio = new EmpleadoNegocio();

            Empleados empleado = negocio.IniciarSesion(
                textUsuario.Text,
                textContraseña.Text
            );

            if (empleado != null)
            {
                MessageBox.Show(
                    "Bienvenido/a " + empleado.nombre + " " + empleado.apellido + "."
                );

                FormularioMenu menu = new FormularioMenu();

                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos, o no tenés permisos para ingresar.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textContraseña.Clear();
                textContraseña.Focus();
            }
        }
    }
}
