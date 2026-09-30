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
    public partial class FormularioProveedor : Form
    {
        private int idProveedorEditar = 0;

        public FormularioProveedor()
        {
            InitializeComponent();
        }

        public FormularioProveedor(Proveedores proveedor)
        {
            InitializeComponent();

            idProveedorEditar = proveedor.id_proveedor;

            textNombreEmpresa.Text = proveedor.nombre_empresa;
            textCUIT.Text = proveedor.cuit;
            textTelefono.Text = proveedor.telefono.ToString();
            txtEmail.Text = proveedor.email;
            textDireccion.Text = proveedor.direccion;

            btnAgregarEmpresa.Text = "Modificar empresa";
        }

        private void btnAgregarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedores proveedorEmpaquetado = new Proveedores
                {
                    nombre_empresa = textNombreEmpresa.Text,
                    cuit = textCUIT.Text,
                    telefono = int.Parse(textTelefono.Text),
                    email = txtEmail.Text,
                    direccion = textDireccion.Text
                };

                ProveedorNegocio negocio = new ProveedorNegocio();

                string respuesta;

                if (idProveedorEditar == 0)
                {
                    respuesta = negocio.RegistrarProveedor(proveedorEmpaquetado);
                }
                else
                {
                    proveedorEmpaquetado.id_proveedor = idProveedorEditar;
                    respuesta = negocio.ModificarProveedor(proveedorEmpaquetado);
                }

                MessageBox.Show(respuesta);

                if (respuesta.StartsWith("Éxito"))
                {
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }

        private void btnVerProveedores_Click(object sender, EventArgs e)
        {
            FormularioListaProveedores formulario =
                new FormularioListaProveedores();

            formulario.ShowDialog();
        }

        private void LimpiarCampos()
        {
            textNombreEmpresa.Clear();
            textCUIT.Clear();
            textTelefono.Clear();
            txtEmail.Clear();
            textDireccion.Clear();
        }
    }
}