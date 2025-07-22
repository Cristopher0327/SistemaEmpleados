using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorEmpleados;

namespace GestorEmpleados
{
    public partial class FormAgregarEmpleado : Form
    {
        public FormAgregarEmpleado()
        {
            InitializeComponent();
            CargarComboBox();        
            GenerarID();             
            AsociarValidaciones();  

            // asociar eventos para mostrar descuentos y tiempo en empresa
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

        // Validaciones: solo letras o solo números según campo
        private void AsociarValidaciones()
        {
            tbNombre.KeyPress += SoloLetras;
            tbCargo.KeyPress += SoloLetras;
            tbSalario.KeyPress += SoloNumeros;
        }

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && tb.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        // Cuando cambia el salario, recalcular descuentos y tiempo
        private void tbSalario_TextChanged(object sender, EventArgs e)
        {
            CalcularDescuentosYTiempo();
        }

        // Cuando cambia la fecha de inicio, recalcular tiempo
        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            CalcularDescuentosYTiempo();
        }

        // Descuentos de AFP, ARS, ISR y tiempo en empresa
        private void CalcularDescuentosYTiempo()
        {
            if (!decimal.TryParse(tbSalario.Text, out decimal salario) || salario <= 0)
            {
                lblAFP.Text = "AFP";
                lblARS.Text = "ARS";
                lblISR.Text = "ISR";
                lblTiempoEmpresa.Text = "Tiempo en la empresa: ";
                return;
            }

            // Tiempo en empresa
            TimeSpan diferencia = DateTime.Now - dtpFechaInicio.Value;
            int años = diferencia.Days / 365;
            int meses = (diferencia.Days % 365) / 30;
            lblTiempoEmpresa.Text = $"{años} años y {meses} meses";

            // AFP
            decimal afp = salario * 0.0287m;
            lblAFP.Text = $"${afp:N2}";

            // ARS
            decimal ars = salario * 0.0304m;
            lblARS.Text = $"${ars:N2}";

            // ISR
            decimal salarioAnual = salario * 12;
            decimal isr = 0;

            if (salarioAnual > 867123)
            {
                isr = ((salarioAnual - 867123) * 0.25m) + 79776;
            }
            else if (salarioAnual > 624329)
            {
                isr = ((salarioAnual - 624329) * 0.20m) + 31203;
            }
            else if (salarioAnual > 416220)
            {
                isr = (salarioAnual - 416220) * 0.15m;
            }

            lblISR.Text = isr > 0 ? $"${(isr / 12):N2}" : "Exento";
        }

        // Guardar empleado
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //validar lo campo obligatorios 
            if (tbNombre.Text.Trim() == "" || tbCargo.Text.Trim() == "" ||
                cmbDepartamento.SelectedIndex == -1 || cmbEstado.SelectedIndex == -1 || tbSalario.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validar salario
            if (!decimal.TryParse(tbSalario.Text, out decimal salario) || salario <= 0)
            {
                MessageBox.Show("Ingrese un salario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validar que la fecha no sea futura
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

            MessageBox.Show("Empleado guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            GenerarID();
        }

        // Cancelar y cerrar formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Limpiar todos los campos del formulario
        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbCargo.Clear();
            tbSalario.Clear();
            cmbDepartamento.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Today;
            lblAFP.Text = "AFP";
            lblARS.Text = "ARS";
            lblISR.Text = "ISR";
            lblTiempoEmpresa.Text = "Tiempo en la empresa: ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
