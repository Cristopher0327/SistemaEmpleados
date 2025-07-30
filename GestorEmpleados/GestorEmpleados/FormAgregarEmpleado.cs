using System;
using System.Linq;
using System.Windows.Forms;

namespace GestorEmpleados
{
    public partial class FormAgregarEmpleado : Form
    {
        // Evento para notificar que se agregó un empleado
        public event EventHandler EmpleadoAgregado;

        private const decimal SALARIO_MAXIMO = 1000000m;

        public FormAgregarEmpleado()
        {
            InitializeComponent();
            CargarComboBox();          // Llena los ComboBox con datos
            GenerarID();               // Genera automáticamente el ID
            AsociarValidaciones();     // Valida letras y números en campos

            // Eventos para recalcular descuentos al cambiar salario o fecha
            tbSalario.TextChanged += tbSalario_TextChanged;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
        }

        // Agrega las opciones a los ComboBox
        private void CargarComboBox()
        {
            cmbDepartamento.Items.AddRange(new string[] {
                "Administración", "IT", "Recursos Humanos", "Ventas", "Finanzas y Contabilidad",
                "Marketing", "Logística y Almacén", "Atención al cliente", "Ventas", "Producción y Operaciones"
            });
            cmbEstado.Items.AddRange(new string[] { "Vigente", "No Vigente" });
        }

        // Genera un ID nuevo y lo bloquea para edición
        private void GenerarID()
        {
            tbIDempleado.Text = EmpleadoManager.GenerarNuevoID().ToString();
            tbIDempleado.ReadOnly = true;
        }

        // Valida ingreso de letras o números según el campo
        private void AsociarValidaciones()
        {
            tbNombre.KeyPress += SoloLetras;
            tbCargo.KeyPress += SoloLetras;
            tbSalario.KeyPress += SoloNumeros;
        }

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && tb.Text.Contains('.'))
                e.Handled = true;
        }

        private void tbSalario_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tbSalario.Text, out decimal salario))
            {
                LimpiarDescuentos();
                return;
            }

            if (salario > SALARIO_MAXIMO)
            {
                MessageBox.Show($"Cantidad excesiva. El máximo permitido es {SALARIO_MAXIMO:C}.", "Límite excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSalario.Clear();
                LimpiarDescuentos();
                return;
            }

            CalcularDescuentosYTiempo();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            CalcularDescuentosYTiempo();
        }

        // Cálculo de AFP, ARS, ISR y tiempo en la empresa
        private void CalcularDescuentosYTiempo()
        {
            if (!decimal.TryParse(tbSalario.Text, out decimal salario) || salario <= 0)
            {
                LimpiarDescuentos();
                return;
            }

            // Cálculo de tiempo trabajado
            TimeSpan diferencia = DateTime.Now - dtpFechaInicio.Value;
            int años = diferencia.Days / 365;
            int meses = (diferencia.Days % 365) / 30;
            lblTiempoEmpresa.Text = $"{años} años y {meses} meses";

            // Cálculo AFP y ARS
            decimal afp = salario * 0.0287m;
            decimal ars = salario * 0.0304m;

            // Cálculo ISR
            decimal salarioAnual = salario * 12;
            decimal isr = 0;

            if (salarioAnual > 867123)
                isr = ((salarioAnual - 867123) * 0.25m) + 79776;
            else if (salarioAnual > 624329)
                isr = ((salarioAnual - 624329) * 0.20m) + 31203;
            else if (salarioAnual > 416220)
                isr = (salarioAnual - 416220) * 0.15m;

            lblAFP.Text = $"${afp:N2}";
            lblARS.Text = $"${ars:N2}";
            lblISR.Text = isr > 0 ? $"${(isr / 12):N2} mensual" : "Exento";
        }

        // Limpia los labels de los cálculos cuando el salario no es válido
        private void LimpiarDescuentos()
        {
            lblAFP.Text = "";
            lblARS.Text = "";
            lblISR.Text = "";
            lblTiempoEmpresa.Text = "";
        }

        // Validación y guardado del empleado
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() == "" || tbCargo.Text.Trim() == "" ||
                cmbDepartamento.SelectedIndex == -1 || cmbEstado.SelectedIndex == -1 || tbSalario.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tbSalario.Text, out decimal salario) || salario <= 0)
            {
                MessageBox.Show("Ingrese un salario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (salario > SALARIO_MAXIMO)
            {
                MessageBox.Show($"La cantidad ingresada es demasiado alta. El máximo permitido es {SALARIO_MAXIMO:C}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpFechaInicio.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de inicio no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crea nuevo objeto empleado con los datos ingresados
            Empleado nuevoEmpleado = new Empleado
            {
                ID = int.Parse(tbIDempleado.Text),
                Nombre = tbNombre.Text.Trim(),
                Cargo = tbCargo.Text.Trim(),
                Departamento = cmbDepartamento.SelectedItem.ToString(),
                Estado = cmbEstado.SelectedItem.ToString(),
                FechaInicio = dtpFechaInicio.Value,
                Salario = salario
            };

            // Guarda el empleado en la base de datos o lista
            EmpleadoManager.AgregarEmpleado(nuevoEmpleado);

            // Notifica a otros formularios que se agregó un empleado
            EmpleadoAgregado?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("Empleado guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            GenerarID();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        // Limpia todos los campos para volver a agregar otro
        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbCargo.Clear();
            tbSalario.Clear();
            cmbDepartamento.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Today;
            LimpiarDescuentos();
        }

        private void FormAgregarEmpleado_Load(object sender, EventArgs e)
        {
            // No se usa, pero queda disponible para inicialización futura
        }
    }
}