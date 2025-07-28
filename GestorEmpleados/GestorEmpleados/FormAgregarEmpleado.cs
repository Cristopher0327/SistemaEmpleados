using System;
using System.Linq;
using System.Windows.Forms;

namespace GestorEmpleados
{
    public partial class FormAgregarEmpleado : Form
    {
        public event EventHandler EmpleadoAgregado;

        private const decimal SALARIO_MAXIMO = 1000000m;

        public FormAgregarEmpleado()
        {
            InitializeComponent();
            CargarComboBox();
            GenerarID();
            AsociarValidaciones();

            tbSalario.TextChanged += tbSalario_TextChanged;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
        }

        private void CargarComboBox()
        {
            cmbDepartamento.Items.AddRange(new string[] { "Administracion", "IT", "Recursos Humanos", "Ventas", "Contabilidad" });
            cmbEstado.Items.AddRange(new string[] { "Vigente", "No Vigente" });
        }

        private void GenerarID()
        {
            tbIDempleado.Text = EmpleadoManager.GenerarNuevoID().ToString();
            tbIDempleado.ReadOnly = true;
        }

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
            if (decimal.TryParse(tbSalario.Text, out decimal salario))
            {
                if (salario > SALARIO_MAXIMO)
                {
                    MessageBox.Show($"Cantidad excesiva. El máximo permitido es {SALARIO_MAXIMO:C}.", "Límite excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbSalario.Clear();
                    lblAFP.Text = "";
                    lblARS.Text = "";
                    lblISR.Text = "";
                    lblTiempoEmpresa.Text = "";
                    return;
                }
            }

            CalcularDescuentosYTiempo();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            CalcularDescuentosYTiempo();
        }

        private void CalcularDescuentosYTiempo()
        {
            if (!decimal.TryParse(tbSalario.Text, out decimal salario) || salario <= 0)
            {
                lblAFP.Text = "";
                lblARS.Text = "";
                lblISR.Text = "";
                lblTiempoEmpresa.Text = "";
                return;
            }

            // Tiempo en la empresa
            TimeSpan diferencia = DateTime.Now - dtpFechaInicio.Value;
            int años = diferencia.Days / 365;
            int meses = (diferencia.Days % 365) / 30;
            lblTiempoEmpresa.Text = $"{años} años y {meses} meses";

            // Cálculos
            decimal afp = salario * 0.0287m;
            decimal ars = salario * 0.0304m;

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
            lblISR.Text = isr > 0 ? $"${(isr / 12):N2}" : "Exento";
        }

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

            EmpleadoManager.AgregarEmpleado(nuevoEmpleado);

            EmpleadoAgregado?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("Empleado guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            GenerarID();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbCargo.Clear();
            tbSalario.Clear();
            cmbDepartamento.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Today;
            lblAFP.Text = "";
            lblARS.Text = "";
            lblISR.Text = "";
            lblTiempoEmpresa.Text = "";
        }
    }
}



