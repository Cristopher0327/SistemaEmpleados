using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace GestorEmpleados
{
    public partial class FormEmpleadosEliminados : Form
    {
        public event EventHandler EmpleadoRestauradoOEliminado;

        public FormEmpleadosEliminados()
        {
            InitializeComponent();

            // Eventos de formularios
            this.Load += FormEmpleadosEliminados_Load;
            this.Activated += FormEmpleadosEliminados_Activated;

            // Eventos de botones
            btnRestaurar.Click += BtnRestaurar_Click;
            btnVaciarEliminados.Click += BtnVaciarEliminados_Click;
            btnBuscarYEliminar.Click += BtnBuscarYEliminar_Click; // Nuevo botón para eliminar por ID
        }

        // Se ejecuta al cargar el formulario
        private void FormEmpleadosEliminados_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        // Se ejecuta cada vez que se activa el formulario
        private void FormEmpleadosEliminados_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        // Refresca el DataGridView
        private void ActualizarDataGrid()
        {
            dgvEliminados.DataSource = null;
            dgvEliminados.DataSource = EmpleadoManager.EmpleadosEliminados.ToList();
            dgvEliminados.ClearSelection();
        }

        // Restaurar empleado seleccionado del DataGridView
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (dgvEliminados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un empleado para restaurar.");
                return;
            }

            var empleado = dgvEliminados.CurrentRow.DataBoundItem as Empleado;

            if (empleado == null) return;

            EmpleadoManager.EmpleadosEliminados.Remove(empleado);
            EmpleadoManager.ListaEmpleados.Add(empleado);

            ActualizarDataGrid();
            MessageBox.Show("Empleado restaurado.");
            EmpleadoRestauradoOEliminado?.Invoke(this, EventArgs.Empty);
        }

        // Vaciar completamente la lista de eliminados
        private void BtnVaciarEliminados_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Estás seguro de vaciar la lista de empleados eliminados?",
                                            "Confirmar vaciado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                EmpleadoManager.EmpleadosEliminados.Clear();
                ActualizarDataGrid();

                MessageBox.Show("Lista vaciada.");
                EmpleadoRestauradoOEliminado?.Invoke(this, EventArgs.Empty);
            }
        }

        // Buscar por ID y eliminar permanentemente
        private void BtnBuscarYEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIDeliminar.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido (número).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleado = EmpleadoManager.EmpleadosEliminados.FirstOrDefault(emp => emp.ID == id);

            if (empleado == null)
            {
                MessageBox.Show("No se encontró ningún empleado con ese ID en la lista de eliminados.",
                                "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar datos del empleado
            string info = $"Nombre: {empleado.Nombre}\n" +
                          $"Departamento: {empleado.Departamento}\n" +
                          $"Cargo: {empleado.Cargo}\n" +
                          $"Salario: {empleado.Salario:C}";

            var confirmar = MessageBox.Show($"Empleado encontrado:\n\n{info}\n\n¿Deseas eliminarlo permanentemente?",
                                            "Confirmar eliminación",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                EmpleadoManager.EmpleadosEliminados.Remove(empleado);
                ActualizarDataGrid();
                MessageBox.Show("Empleado eliminado permanentemente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmpleadoRestauradoOEliminado?.Invoke(this, EventArgs.Empty);
            }
        }

        private void FormEmpleadosEliminados_Load_1(object sender, EventArgs e)
        {

        }
    }
}

