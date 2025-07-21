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
        }

        private void CargarComboBox()
        {
            cmbDepartamento.Items.AddRange(new string[] { "Administracion", "IT", "Recursos Humanos", "Ventas", "Contabilidad" });
            cmbEstado.Items.AddRange(new string[] { "Vigente", "No Vigente" });
        }

        private void tbSalario_TextChanged(object sender, EventArgs e)
        {
            CalcularDescuentosYTiempo();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            CalcularDescuentosYTiempo();
        }


        //descuentos en las ARS, AFP e ISR 
        private void CalcularDescuentosYTiempo()
        {
            if (!decimal.TryParse(tbSalario.Text, out decimal salario) || salario <= 0)
            {
                lblAFP.Text = lblARS.Text = lblISR.Text = lblTiempoEmpresa.Text = "N/D";
                return;
            }

            // calcular tiempo en la empresa
            TimeSpan diferencia = DateTime.Now - dtpFechaInicio.Value;
            int años = (int)(diferencia.Days / 365);
            int meses = (int)((diferencia.Days % 365) / 30);
            lblTiempoEmpresa.Text = $"{años} años y {meses} meses";

            // AFP
            decimal afp = salario * 0.0287m;
            lblAFP.Text = afp.ToString("C");

            // ARS
            decimal ars = salario * 0.0304m;
            lblARS.Text = ars.ToString("C");

            // ISR se calculo por año y luego se convierte a mensual 
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

            lblISR.Text = isr > 0 ? (isr / 12).ToString("C") : "Exento";
        }


        //boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (tbIDempleado.Text.Trim() == "" || tbNombre.Text.Trim() == "" || tbCargo.Text.Trim() == "" ||
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

            if (dtpFechaInicio.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de inicio no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Empleado guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // limpiar campos
        }


        //boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}