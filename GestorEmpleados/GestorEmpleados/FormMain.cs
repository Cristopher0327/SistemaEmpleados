using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorEmpleados
{
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
            AbrirFormulario(new FormAgregarEmpleado());
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormActualizarEmpleado());
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEliminarEmpleado());
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

        private void AbrirFormulario(Form formularioHijo)
        {
            // Cierra formularios hijos abiertos
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            formularioHijo.MdiParent = this;
            formularioHijo.Dock = DockStyle.Fill;
            formularioHijo.Show();
        }

    }
}
