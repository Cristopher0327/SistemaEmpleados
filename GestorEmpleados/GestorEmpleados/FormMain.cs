using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorEmpleados
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormMostrarEmpleados());
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            var formAgregar = this.MdiChildren.OfType<FormAgregarEmpleado>().FirstOrDefault();

            if (formAgregar == null)
            {
                formAgregar = new FormAgregarEmpleado();

                formAgregar.EmpleadoAgregado += (s, ev) =>
                {
                    var formMostrar = this.MdiChildren
                        .OfType<FormMostrarEmpleados>()
                        .FirstOrDefault();

                    if (formMostrar != null)
                    {
                        formMostrar.CargarEmpleados();
                    }
                };

                formAgregar.MdiParent = this;
                formAgregar.Dock = DockStyle.Fill;
                formAgregar.Show();
            }
            else
            {
                formAgregar.BringToFront();
                formAgregar.WindowState = FormWindowState.Normal;
            }
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormActualizarEmpleado());
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            // Buscar si ya hay uno abierto
            var formEliminadosExistente = this.MdiChildren
                .OfType<FormEmpleadosEliminados>()
                .FirstOrDefault();

            if (formEliminadosExistente != null)
            {
                formEliminadosExistente.BringToFront();
                formEliminadosExistente.WindowState = FormWindowState.Normal;
                return;
            }

            // Crear uno nuevo
            FormEmpleadosEliminados formEliminados = new FormEmpleadosEliminados();
            formEliminados.MdiParent = this;
            formEliminados.Dock = DockStyle.Fill;

            var formMostrar = this.MdiChildren
                .OfType<FormMostrarEmpleados>()
                .FirstOrDefault();

            if (formMostrar != null)
            {
                formMostrar.ConectarEventos(formEliminados);
            }

            formEliminados.Show();
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar empleados como CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Cabecera con punto y coma como separador
                        writer.WriteLine("ID;Nombre;Apellido;Cargo;Sueldo;FechaNacimiento");

                        foreach (Empleado emp in EmpleadoManager.ListaEmpleados)
                        {
                            // Línea de datos con punto y coma como separador
                            writer.WriteLine($"{emp.ID};{emp.Nombre};{emp.Apellido};{emp.Cargo};{emp.Salario};{emp.FechaNacimiento:dd/MM/yyyy}");
                        }
                    }

                    MessageBox.Show("Empleados exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormulario(Form nuevoFormulario)
        {
            var formularioExistente = this.MdiChildren
                .FirstOrDefault(f => f.GetType() == nuevoFormulario.GetType() && !f.IsDisposed);

            if (formularioExistente != null)
            {
                formularioExistente.BringToFront();
                formularioExistente.WindowState = FormWindowState.Normal;
            }
            else
            {
                nuevoFormulario.MdiParent = this;
                nuevoFormulario.Dock = DockStyle.Fill;
                nuevoFormulario.Show();
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {






            
        }
    }
}
