using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            AbrirFormulario(new FormExportarCSV());
            MessageBox.Show("Los datos fueron exportados a CSV.");
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
    }
}
