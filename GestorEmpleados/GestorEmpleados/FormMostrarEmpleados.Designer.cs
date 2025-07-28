namespace GestorEmpleados
{
    partial class FormMostrarEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblBusquedaEmpleado = new System.Windows.Forms.Label();
            this.tbBusquedaEmpleado = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminarSeleccionado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.GridColor = System.Drawing.Color.Bisque;
            this.dgvEmpleados.Location = new System.Drawing.Point(27, 182);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 82;
            this.dgvEmpleados.RowTemplate.Height = 33;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(1249, 380);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrar.Font = new System.Drawing.Font("Constantia", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(730, 106);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(163, 66);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblBusquedaEmpleado
            // 
            this.lblBusquedaEmpleado.AutoSize = true;
            this.lblBusquedaEmpleado.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaEmpleado.Location = new System.Drawing.Point(7, 128);
            this.lblBusquedaEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusquedaEmpleado.Name = "lblBusquedaEmpleado";
            this.lblBusquedaEmpleado.Size = new System.Drawing.Size(141, 26);
            this.lblBusquedaEmpleado.TabIndex = 2;
            this.lblBusquedaEmpleado.Text = "Buscar por ID:";
            // 
            // tbBusquedaEmpleado
            // 
            this.tbBusquedaEmpleado.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusquedaEmpleado.Location = new System.Drawing.Point(152, 125);
            this.tbBusquedaEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.tbBusquedaEmpleado.Name = "tbBusquedaEmpleado";
            this.tbBusquedaEmpleado.Size = new System.Drawing.Size(186, 32);
            this.tbBusquedaEmpleado.TabIndex = 3;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBusqueda.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(351, 108);
            this.btnBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(184, 64);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Buscar Empleado";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMostrar.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(539, 106);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(187, 66);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminarSeleccionado
            // 
            this.btnEliminarSeleccionado.Location = new System.Drawing.Point(898, 106);
            this.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            this.btnEliminarSeleccionado.Size = new System.Drawing.Size(135, 66);
            this.btnEliminarSeleccionado.TabIndex = 6;
            this.btnEliminarSeleccionado.Text = "Eliminar";
            this.btnEliminarSeleccionado.UseVisualStyleBackColor = true;
            this.btnEliminarSeleccionado.Click += new System.EventHandler(this.btnEliminarSeleccionado_Click);
            // 
            // FormMostrarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1304, 685);
            this.Controls.Add(this.btnEliminarSeleccionado);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.tbBusquedaEmpleado);
            this.Controls.Add(this.lblBusquedaEmpleado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvEmpleados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMostrarEmpleados";
            this.Text = "Empleados Registrados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblBusquedaEmpleado;
        private System.Windows.Forms.TextBox tbBusquedaEmpleado;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
    }
}