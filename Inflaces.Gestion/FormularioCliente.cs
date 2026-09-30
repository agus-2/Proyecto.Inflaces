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
    public partial class FormularioCliente : Form
    {
        private int idClienteEditar = 0;
        public FormularioCliente()
        {
            InitializeComponent();
        }
        public FormularioCliente(Clientes cliente)
        {
            InitializeComponent();

            idClienteEditar = cliente.id_cliente;
            txtnombre_completo.Text = cliente.nombre_completo;
            txtcuit.Text = cliente.cuit;
            chkMayorist.Checked = cliente.tipo_cliente;
            txttelefono.Text = cliente.telefono;
            txtemail.Text = cliente.email;
            txtdireccion.Text = cliente.direccion;
            btnAddCliente.Text = "Modificar cliente";
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //agarra el texto ingresado y lo empaqueta
                Clientes clienteEmpaquetado = new Clientes
                {
                    nombre_completo = txtnombre_completo.Text,
                    cuit = txtcuit.Text,
                    tipo_cliente = chkMayorist.Checked, // true si es mayorista, false si es minorista
                    telefono = txttelefono.Text,
                    email = txtemail.Text,
                    direccion = txtdireccion.Text
                };

                //llamo al metodo en la capa de negocio
                ClienteNegocio negocio = new ClienteNegocio();
                string respuesta;

                if (idClienteEditar == 0)
                {
                    respuesta = negocio.RegistrarCliente(clienteEmpaquetado);
                }
                else
                {
                    clienteEmpaquetado.id_cliente = idClienteEditar;
                    respuesta = negocio.ModificarCliente(clienteEmpaquetado);
                }

                MessageBox.Show(respuesta);

                if (respuesta.StartsWith("Éxito"))
                {
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error" + ex.Message);
            }
        }
        private void LimpiarCampos() { 
            txtnombre_completo.Clear(); 
            txtcuit.Clear();
            chkMayorist.Checked = false;
            txttelefono.Clear();
            txtemail.Clear();
            txtdireccion.Clear(); 
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            FormularioListaClientes formulario = new FormularioListaClientes();
            formulario.ShowDialog();
        }

      
    }
}