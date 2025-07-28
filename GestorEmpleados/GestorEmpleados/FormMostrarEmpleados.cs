using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorEmpleados
{
    public partial class FormMostrarEmpleados : Form
    {
        private bool eliminando = false;

        public FormMostrarEmpleados()
        {
            InitializeComponent();

            btnCerrar.Click += BtnCerrar_Click;

            // Asignar evento Click correctamente
            btnEliminarSeleccionado.Click += btnEliminarSeleccionado_Click;

            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Load += FormMostrarEmpleados_Load;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMostrarEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        public void CargarEmpleados()
        {
            var empleados = EmpleadoManager.ListaEmpleados;

            dgvEmpleados.DataSource = null;

            if (empleados.Count == 0)
            {
                MessageBox.Show("No hay empleados registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvEmpleados.DataSource = empleados;
            dgvEmpleados.ClearSelection();
            dgvEmpleados.CurrentCell = null; // Evita selección automática al cargar
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBusquedaEmpleado.Text.Trim(), out int idBuscado))
            {
                var empleado = EmpleadoManager.ListaEmpleados.FirstOrDefault(emp => emp.ID == idBuscado);

                dgvEmpleados.DataSource = null;

                if (empleado != null)
                {
                    dgvEmpleados.DataSource = new List<Empleado> { empleado };
                }
                else
                {
                    MessageBox.Show("No se encontró un empleado con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvEmpleados.ClearSelection();
                dgvEmpleados.CurrentCell = null;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido (solo números).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            if (eliminando) return;

            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún empleado seleccionado para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var empleado = dgvEmpleados.CurrentRow.DataBoundItem as Empleado;

            if (empleado == null)
            {
                MessageBox.Show("Error al obtener el empleado seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmar = MessageBox.Show($"¿Estás seguro de eliminar al empleado {empleado.Nombre}?",
                                            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.No)
            {
                return;
            }

            eliminando = true;

            try
            {
                EmpleadoManager.ListaEmpleados.RemoveAll(emp => emp.ID == empleado.ID);
                EmpleadoManager.EmpleadosEliminados.Add(empleado);

                CargarEmpleados();
                dgvEmpleados.ClearSelection();
                dgvEmpleados.CurrentCell = null;

                MessageBox.Show("Empleado eliminado correctamente. Puedes restaurarlo desde el historial.",
                                "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                eliminando = false;
            }
        }

        // ✅ ESTE MÉTODO PERMITE ACTUALIZAR AUTOMÁTICAMENTE SIN ABRIR VENTANAS
        internal void SuscribirFormulario(FormEmpleadosEliminados formEliminados)
        {
            // Cuando se restaura o vacía un empleado desde el formulario de eliminados...
            formEliminados.EmpleadoRestauradoOEliminado += (s, e) =>
            {
                CargarEmpleados(); // ...recarga automáticamente los datos en este formulario.
            };
        }

        internal void ConectarEventos(FormEmpleadosEliminados formEliminados)
        {
            formEliminados.EmpleadoRestauradoOEliminado -= FormEliminados_EmpleadoRestauradoOEliminado;
            formEliminados.EmpleadoRestauradoOEliminado += FormEliminados_EmpleadoRestauradoOEliminado;
        }

        private void FormEliminados_EmpleadoRestauradoOEliminado(object sender, EventArgs e)
        {
            CargarEmpleados(); // Refresca el DataGridView
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



