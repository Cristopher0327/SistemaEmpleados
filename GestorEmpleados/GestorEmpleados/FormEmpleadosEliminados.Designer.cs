namespace GestorEmpleados
{
    partial class FormEmpleadosEliminados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleadosEliminados));
            this.dgvEliminados = new System.Windows.Forms.DataGridView();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnVaciarEliminados = new System.Windows.Forms.Button();
            this.btnBuscarYEliminar = new System.Windows.Forms.Button();
            this.lblEmpleadoEliminar = new System.Windows.Forms.Label();
            this.tbIDeliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminados
            // 
            this.dgvEliminados.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminados.Location = new System.Drawing.Point(24, 308);
            this.dgvEliminados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEliminados.Name = "dgvEliminados";
            this.dgvEliminados.RowHeadersWidth = 62;
            this.dgvEliminados.RowTemplate.Height = 28;
            this.dgvEliminados.Size = new System.Drawing.Size(1363, 366);
            this.dgvEliminados.TabIndex = 0;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRestaurar.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(806, 199);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(259, 86);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar Empleado";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnVaciarEliminados
            // 
            this.btnVaciarEliminados.BackColor = System.Drawing.Color.Crimson;
            this.btnVaciarEliminados.Font = new System.Drawing.Font("Constantia", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciarEliminados.Location = new System.Drawing.Point(1073, 196);
            this.btnVaciarEliminados.Margin = new System.Windows.Forms.Padding(4);
            this.btnVaciarEliminados.Name = "btnVaciarEliminados";
            this.btnVaciarEliminados.Size = new System.Drawing.Size(259, 89);
            this.btnVaciarEliminados.TabIndex = 2;
            this.btnVaciarEliminados.Text = "Vaciar Registro";
            this.btnVaciarEliminados.UseVisualStyleBackColor = false;
            // 
            // btnBuscarYEliminar
            // 
            this.btnBuscarYEliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBuscarYEliminar.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarYEliminar.Location = new System.Drawing.Point(567, 199);
            this.btnBuscarYEliminar.Name = "btnBuscarYEliminar";
            this.btnBuscarYEliminar.Size = new System.Drawing.Size(232, 86);
            this.btnBuscarYEliminar.TabIndex = 3;
            this.btnBuscarYEliminar.Text = "Buscar ID";
            this.btnBuscarYEliminar.UseVisualStyleBackColor = false;
            // 
            // lblEmpleadoEliminar
            // 
            this.lblEmpleadoEliminar.AutoSize = true;
            this.lblEmpleadoEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleadoEliminar.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoEliminar.Location = new System.Drawing.Point(55, 231);
            this.lblEmpleadoEliminar.Name = "lblEmpleadoEliminar";
            this.lblEmpleadoEliminar.Size = new System.Drawing.Size(340, 33);
            this.lblEmpleadoEliminar.TabIndex = 4;
            this.lblEmpleadoEliminar.Text = "ID del Empleado a eliminar:";
            // 
            // tbIDeliminar
            // 
            this.tbIDeliminar.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDeliminar.Location = new System.Drawing.Point(394, 228);
            this.tbIDeliminar.Name = "tbIDeliminar";
            this.tbIDeliminar.Size = new System.Drawing.Size(158, 40);
            this.tbIDeliminar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = "Empleados Eliminados";
            // 
            // FormEmpleadosEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1432, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIDeliminar);
            this.Controls.Add(this.lblEmpleadoEliminar);
            this.Controls.Add(this.btnBuscarYEliminar);
            this.Controls.Add(this.btnVaciarEliminados);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.dgvEliminados);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmpleadosEliminados";
            this.Text = "Empleado Eliminados";
            this.Load += new System.EventHandler(this.FormEmpleadosEliminados_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEliminados;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnVaciarEliminados;
        private System.Windows.Forms.Button btnBuscarYEliminar;
        private System.Windows.Forms.Label lblEmpleadoEliminar;
        private System.Windows.Forms.TextBox tbIDeliminar;
        private System.Windows.Forms.Label label1;
    }
}