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
        public FormularioCliente()
        {
            InitializeComponent();
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
                string respuesta = negocio.RegistrarCliente(clienteEmpaquetado);

                //muestra resultado al usuario y limpia pantalla si todo esta bien
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
    }
}