namespace GestorEmpleados
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnMostrarEmpleados = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightBlue;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnExportarCSV);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnActualizarEmpleado);
            this.panelMenu.Controls.Add(this.btnEliminarEmpleado);
            this.panelMenu.Controls.Add(this.btnAgregarEmpleado);
            this.panelMenu.Controls.Add(this.btnMostrarEmpleados);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(341, 790);
            this.panelMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 74);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menú";
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExportarCSV.Font = new System.Drawing.Font("Constantia", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarCSV.Location = new System.Drawing.Point(51, 566);
            this.btnExportarCSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(217, 94);
            this.btnExportarCSV.TabIndex = 5;
            this.btnExportarCSV.Text = "\tExportar a CSV";
            this.btnExportarCSV.UseVisualStyleBackColor = false;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(51, 686);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(217, 64);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.CadetBlue;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Constantia", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(51, 342);
            this.btnActualizarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(217, 98);
            this.btnActualizarEmpleado.TabIndex = 3;
            this.btnActualizarEmpleado.Text = "Actualizar empleado";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Constantia", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(51, 458);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(217, 100);
            this.btnEliminarEmpleado.TabIndex = 2;
            this.btnEliminarEmpleado.Text = "Empleados Eliminados";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Constantia", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(51, 227);
            this.btnAgregarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(217, 98);
            this.btnAgregarEmpleado.TabIndex = 1;
            this.btnAgregarEmpleado.Text = "Agregar empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnMostrarEmpleados
            // 
            this.btnMostrarEmpleados.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMostrarEmpleados.Font = new System.Drawing.Font("Constantia", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEmpleados.Location = new System.Drawing.Point(51, 104);
            this.btnMostrarEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarEmpleados.Name = "btnMostrarEmpleados";
            this.btnMostrarEmpleados.Size = new System.Drawing.Size(217, 108);
            this.btnMostrarEmpleados.TabIndex = 0;
            this.btnMostrarEmpleados.Text = "Mostrar empleados";
            this.btnMostrarEmpleados.UseVisualStyleBackColor = false;
            this.btnMostrarEmpleados.Click += new System.EventHandler(this.btnMostrarEmpleados_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1093, 790);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "C&P Systems - Gestor de Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnExportarCSV;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnMostrarEmpleados;
        private System.Windows.Forms.Label label1;
    }
}

