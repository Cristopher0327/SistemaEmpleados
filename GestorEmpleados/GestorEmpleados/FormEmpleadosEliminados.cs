using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorEmpleados
{
    public partial class FormEmpleadosEliminados : Form
    {
        private object lblMensaje;

        public event EventHandler EmpleadoRestauradoOEliminado;

        public FormEmpleadosEliminados()
        {
            InitializeComponent();

            this.Load += FormEmpleadosEliminados_Load;
            this.Activated += FormEmpleadosEliminados_Activated; // Para refrescar al activarse

            btnRestaurar.Click += BtnRestaurar_Click;
            btnVaciarEliminados.Click += BtnVaciarEliminados_Click;
        }

        // Refrescar cada vez que se activa el formulario
        private void FormEmpleadosEliminados_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void FormEmpleadosEliminados_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dgvEliminados.DataSource = null;
            dgvEliminados.DataSource = EmpleadoManager.EmpleadosEliminados.ToList();
            dgvEliminados.ClearSelection();

            if (EmpleadoManager.EmpleadosEliminados.Count == 0)
            {
                
            }
        }

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
    }
}

