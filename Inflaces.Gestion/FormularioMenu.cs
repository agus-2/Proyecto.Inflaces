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
    public partial class FormularioMenu : Form
    {
        public FormularioMenu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormularioCliente formulario = new FormularioCliente();
            formulario.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormularioProveedor formulario = new FormularioProveedor();
            formulario.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormularioEmpleado formulario = new FormularioEmpleado();
            formulario.ShowDialog();
        }

        private void btnMateriaPrima_Click(object sender, EventArgs e)
        {
            FormularioMateriaPrima formulario = new FormularioMateriaPrima();
            formulario.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormularioProducto formulario = new FormularioProducto();
            formulario.ShowDialog();
        }
    }
}
   
