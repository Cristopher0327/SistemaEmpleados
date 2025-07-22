using System;
using System.Windows.Forms;

namespace GestorEmpleados
{
    public partial class FormMostrarEmpleados : Form
    {
        public FormMostrarEmpleados()
        {
            InitializeComponent();
            // Configura el evento del botón cerrar
            btnCerrar.Click += BtnCerrar_Click;

            // Configura otras propiedades si quieres
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Evento Load del formulario
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
    }
}
