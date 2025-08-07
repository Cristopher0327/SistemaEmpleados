using System;
using System.Linq;
using System.Windows.Forms;

namespace GestorEmpleados
{
    public partial class FormActualizarEmpleado : Form
    {
        private Empleado empleadoEncontrado;

        public FormActualizarEmpleado()
        {
            InitializeComponent();
            CargarComboBoxDepartamento();
            CargarComboBoxEstado();

            // Establecer DropDownList para que no permitan edición manual
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            // Asociar validaciones KeyPress
            txtID.KeyPress += SoloNumerosConMensaje;
            txtNombre.KeyPress += SoloLetrasConMensaje;
            txtApellido.KeyPress += SoloLetrasConMensaje;
            txtSueldo.KeyPress += SoloNumerosConMensaje;
        }

        private void CargarComboBoxDepartamento()
        {
            cmbDepartamento.Items.Clear();
            cmbDepartamento.Items.AddRange(new string[] {
                "Administración", "IT", "Recursos Humanos", "Ventas", "Finanzas y Contabilidad",
                "Marketing", "Logística y Almacén", "Atención al cliente", "Producción y Operaciones"
            });
        }

        private void CargarComboBoxEstado()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new string[] { "Vigente", "No Vigente" });
        }

        private void SoloNumerosConMensaje(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SoloLetrasConMensaje(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text.Trim(), out int id))
            {
                var empGlobal = EmpleadoManager.ListaEmpleados.FirstOrDefault(emp => emp.ID == id);

                if (empGlobal != null)
                {
                    string nombre = Convert.ToString(empGlobal.Nombre) ?? "";
                    string apellido = Convert.ToString(empGlobal.Apellido) ?? "";
                    string cargo = Convert.ToString(empGlobal.Cargo) ?? "";
                    string estado = Convert.ToString(empGlobal.Estado) ?? "";
                    string departamento = Convert.ToString(empGlobal.Departamento) ?? "";

                    decimal salario = 0m;
                    DateTime fechaNacimiento = DateTime.MinValue;
                    DateTime fechaInicio = DateTime.MinValue;

                    try { salario = empGlobal.Salario != null ? Convert.ToDecimal(empGlobal.Salario) : 0m; }
                    catch { salario = 0m; }

                    try { fechaNacimiento = empGlobal.FechaNacimiento != null ? Convert.ToDateTime(empGlobal.FechaNacimiento) : DateTime.MinValue; }
                    catch { fechaNacimiento = DateTime.MinValue; }

                    try { fechaInicio = empGlobal.FechaInicio != null ? Convert.ToDateTime(empGlobal.FechaInicio) : DateTime.MinValue; }
                    catch { fechaInicio = DateTime.MinValue; }

                    if (string.IsNullOrWhiteSpace(nombre) ||
                        string.IsNullOrWhiteSpace(apellido) ||
                        string.IsNullOrWhiteSpace(cargo) ||
                        salario <= 0 ||
                        fechaNacimiento == DateTime.MinValue || fechaNacimiento > DateTime.Now)
                    {
                        MessageBox.Show("Datos inválidos. Verifique nombre, apellido, cargo, salario y fecha de nacimiento.");
                        empleadoEncontrado = null;
                        LimpiarCampos();
                        return;
                    }

                    empleadoEncontrado = new Empleado
                    {
                        ID = empGlobal.ID,
                        Nombre = nombre,
                        Apellido = apellido,
                        Cargo = cargo,
                        Salario = salario,
                        FechaNacimiento = fechaNacimiento,
                        Estado = estado,
                        FechaInicio = fechaInicio,
                        Departamento = departamento
                    };

                    txtNombre.Text = nombre;
                    txtApellido.Text = apellido;
                    txtCargo.Text = cargo;
                    txtSueldo.Text = salario.ToString("N2");

                    // Aquí está la agregación que solicitaste:
                    dtpFechaNacimiento.Value = fechaNacimiento != DateTime.MinValue ? fechaNacimiento : DateTime.Now;
                    dtpFechaInicio.Value = fechaInicio != DateTime.MinValue ? fechaInicio : DateTime.Now;

                    if (cmbEstado.Items.Contains(estado))
                        cmbEstado.SelectedItem = estado;
                    else
                        cmbEstado.SelectedIndex = -1;

                    if (cmbDepartamento.Items.Contains(departamento))
                        cmbDepartamento.SelectedItem = departamento;
                    else
                        cmbDepartamento.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado.");
                    empleadoEncontrado = null;
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("ID inválido.");
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (empleadoEncontrado == null)
            {
                MessageBox.Show("Primero debe buscar un empleado para actualizar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtSueldo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (!decimal.TryParse(txtSueldo.Text, out decimal salario) || salario <= 0)
            {
                MessageBox.Show("Ingrese un salario válido mayor que cero.");
                return;
            }

            // Validar fecha nacimiento mínima 19 años
            if (dtpFechaNacimiento.Value >= DateTime.Now || CalcularEdad(dtpFechaNacimiento.Value) < 19)
            {
                MessageBox.Show("La fecha de nacimiento es inválida. El empleado debe tener al menos 19 años.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            empleadoEncontrado.Nombre = txtNombre.Text.Trim();
            empleadoEncontrado.Apellido = txtApellido.Text.Trim();
            empleadoEncontrado.Cargo = txtCargo.Text.Trim();
            empleadoEncontrado.Salario = salario;
            empleadoEncontrado.FechaNacimiento = dtpFechaNacimiento.Value;

            if (cmbEstado.SelectedIndex != -1)
                empleadoEncontrado.Estado = Convert.ToString(cmbEstado.SelectedItem);

            if (cmbDepartamento.SelectedIndex != -1)
                empleadoEncontrado.Departamento = Convert.ToString(cmbDepartamento.SelectedItem);

            // FechaInicio se mantiene igual sin cambios

            int indice = EmpleadoManager.ListaEmpleados.FindIndex(emp => emp.ID == empleadoEncontrado.ID);
            if (indice >= 0)
            {
                EmpleadoManager.ListaEmpleados[indice] = empleadoEncontrado;
                MessageBox.Show("Empleado actualizado correctamente.");
                LimpiarCampos();
                empleadoEncontrado = null;
            }
            else
            {
                MessageBox.Show("Error: empleado no encontrado en la lista.");
            }
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            var hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCargo.Clear();
            txtSueldo.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            cmbEstado.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Now;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}







