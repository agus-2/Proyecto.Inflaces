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
    public partial class FormularioFabricacion : Form
    {
        private int idFabricacionEditar = 0;
        private EmpleadoNegocio negocioEmpleado = new EmpleadoNegocio();
        private ProductoNegocio negocioProducto = new ProductoNegocio();
        public FormularioFabricacion()
        {
            InitializeComponent();
        }

        private void FormularioFabricacion_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarEmpleados();
        }
        private void CargarProductos()
        {
            try
            {
                cmboProducto.DataSource = negocioProducto.ListarProductos();
                cmboProducto.ValueMember = "id_producto";
                cmboProducto.DisplayMember = "nombre";
                cmboProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de productos: " + ex.Message);
            }
        }
        private void CargarEmpleados() {
            try
            {
                cmboEmpleado.DataSource = negocioEmpleado.ListarEmpleados();
                cmboEmpleado.ValueMember = "id_empleado";
                cmboEmpleado.DisplayMember = "apellido";
                cmboEmpleado.SelectedIndex = -1;
            } catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de empleados: " + ex.Message);
            }
        }
        public FormularioFabricacion(Fabricacion fabricacion)
        {
            InitializeComponent();

            idFabricacionEditar = fabricacion.id_fabricacion;
            cmboProducto.SelectedValue = fabricacion.id_producto;
            cmboEmpleado.SelectedValue = fabricacion.id_empleado;
            dtpInicio.Value = fabricacion.inicio;
            dtpFin.Value = fabricacion.fin;
            txtCantidadCiclo.Text = fabricacion.cantidad.ToString();
            txtEstadoCiclo.Text = fabricacion.estado;
        }

        private void LimpiarCampos()
        {
            idFabricacionEditar = 0;
            if (cmboEmpleado.Items.Count > 0) cmboEmpleado.SelectedIndex = -1;
            if (cmboProducto.Items.Count > 0) cmboProducto.SelectedIndex = -1;
            dtpFin.Value = DateTime.Now;
            dtpInicio.Value = DateTime.Now;
            txtCantidadCiclo.Clear();
            txtEstadoCiclo.Clear();
        }

        private void btnCrearCiclo_Click(object sender, EventArgs e)
        {
            if (dtpFin.Value < dtpInicio.Value) {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.");
                return; 
            }
            try
            {
                Fabricacion cicloEmpaquetado = new Fabricacion
                {
                    id_producto = (int)cmboProducto.SelectedValue,
                    id_empleado = (int)cmboEmpleado.SelectedValue,
                    inicio = dtpInicio.Value,
                    fin = dtpFin.Value,
                    cantidad = int.Parse(txtCantidadCiclo.Text),
                    estado = txtEstadoCiclo.Text
                };

                FabricacionNegocio fabric = new FabricacionNegocio();
                string respuesta;

                if (idFabricacionEditar == 0)
                {
                    respuesta = fabric.CrearCiclo(cicloEmpaquetado);
                }
                else
                {
                    cicloEmpaquetado.id_fabricacion = idFabricacionEditar;
                    respuesta = fabric.ModificarCiclo(cicloEmpaquetado);
                }

                MessageBox.Show(respuesta);

                if (respuesta.StartsWith("Éxito"))
                {
                    if (idFabricacionEditar != 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnVerCiclos_Click(object sender, EventArgs e)
        {
            ListarFabricacion formulario = new ListarFabricacion();
            formulario.ShowDialog();
        }
    }
}
