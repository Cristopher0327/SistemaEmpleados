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
            this.dgvEliminados = new System.Windows.Forms.DataGridView();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnVaciarEliminados = new System.Windows.Forms.Button();
            this.btnBuscarYEliminar = new System.Windows.Forms.Button();
            this.lblEmpleadoEliminar = new System.Windows.Forms.Label();
            this.tbIDeliminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminados
            // 
            this.dgvEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminados.Location = new System.Drawing.Point(64, 233);
            this.dgvEliminados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEliminados.Name = "dgvEliminados";
            this.dgvEliminados.RowHeadersWidth = 62;
            this.dgvEliminados.RowTemplate.Height = 28;
            this.dgvEliminados.Size = new System.Drawing.Size(1363, 366);
            this.dgvEliminados.TabIndex = 0;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(788, 80);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(259, 86);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar Empleado";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnVaciarEliminados
            // 
            this.btnVaciarEliminados.Location = new System.Drawing.Point(1055, 77);
            this.btnVaciarEliminados.Margin = new System.Windows.Forms.Padding(4);
            this.btnVaciarEliminados.Name = "btnVaciarEliminados";
            this.btnVaciarEliminados.Size = new System.Drawing.Size(259, 89);
            this.btnVaciarEliminados.TabIndex = 2;
            this.btnVaciarEliminados.Text = "Vaciar Eliminados";
            this.btnVaciarEliminados.UseVisualStyleBackColor = true;
            // 
            // btnBuscarYEliminar
            // 
            this.btnBuscarYEliminar.Location = new System.Drawing.Point(549, 80);
            this.btnBuscarYEliminar.Name = "btnBuscarYEliminar";
            this.btnBuscarYEliminar.Size = new System.Drawing.Size(232, 86);
            this.btnBuscarYEliminar.TabIndex = 3;
            this.btnBuscarYEliminar.Text = "Buscar ID";
            this.btnBuscarYEliminar.UseVisualStyleBackColor = true;
            // 
            // lblEmpleadoEliminar
            // 
            this.lblEmpleadoEliminar.AutoSize = true;
            this.lblEmpleadoEliminar.Location = new System.Drawing.Point(37, 112);
            this.lblEmpleadoEliminar.Name = "lblEmpleadoEliminar";
            this.lblEmpleadoEliminar.Size = new System.Drawing.Size(268, 25);
            this.lblEmpleadoEliminar.TabIndex = 4;
            this.lblEmpleadoEliminar.Text = "ID del Empleado a eliminar";
            // 
            // tbIDeliminar
            // 
            this.tbIDeliminar.Location = new System.Drawing.Point(337, 106);
            this.tbIDeliminar.Name = "tbIDeliminar";
            this.tbIDeliminar.Size = new System.Drawing.Size(158, 31);
            this.tbIDeliminar.TabIndex = 5;
            // 
            // FormEmpleadosEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 727);
            this.Controls.Add(this.tbIDeliminar);
            this.Controls.Add(this.lblEmpleadoEliminar);
            this.Controls.Add(this.btnBuscarYEliminar);
            this.Controls.Add(this.btnVaciarEliminados);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.dgvEliminados);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmpleadosEliminados";
            this.Text = "Empleado Eliminados";
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
    }
}