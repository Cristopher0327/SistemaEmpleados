using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorEmpleados
{
    public partial class FormMostrarEmpleados : Form
    {
        public FormMostrarEmpleados()
        {
            InitializeComponent();

            //botón cerrar
            btnCerrar.Click += BtnCerrar_Click;

            // Seleccion completa de la fila al hacer clic
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Evento que se ejecuta al cargar el formulario
            this.Load += FormMostrarEmpleados_Load;
        }

        // Evento del boton cerrar
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void FormMostrarEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        // Carga la lista completa de empleados al dgvEmpleados
        private void CargarEmpleados()
        {
            var empleados = EmpleadoManager.ListaEmpleados;

            if (empleados.Count == 0)
            {
                MessageBox.Show("No hay empleados registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;
        }

        // para buscar un empleado por su ID
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBusquedaEmpleado.Text.Trim(), out int idBuscado))
            {
                var empleado = EmpleadoManager.ListaEmpleados.FirstOrDefault(emp => emp.ID == idBuscado);

                if (empleado != null)
                {
                    dgvEmpleados.DataSource = new List<Empleado> { empleado };
                }
                else
                {
                    MessageBox.Show("No se encontró un empleado con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvEmpleados.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido (solo números).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón para mostrar todos los empleados nuevamente
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = EmpleadoManager.ListaEmpleados;
        }
    }
}
