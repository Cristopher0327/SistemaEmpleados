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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminados
            // 
            this.dgvEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminados.Location = new System.Drawing.Point(12, 132);
            this.dgvEliminados.Name = "dgvEliminados";
            this.dgvEliminados.RowHeadersWidth = 62;
            this.dgvEliminados.RowTemplate.Height = 28;
            this.dgvEliminados.Size = new System.Drawing.Size(776, 293);
            this.dgvEliminados.TabIndex = 0;

            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(31, 36);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(194, 69);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar Empleado";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnVaciarEliminados
            // 
            this.btnVaciarEliminados.Location = new System.Drawing.Point(245, 36);
            this.btnVaciarEliminados.Name = "btnVaciarEliminados";
            this.btnVaciarEliminados.Size = new System.Drawing.Size(194, 71);
            this.btnVaciarEliminados.TabIndex = 2;
            this.btnVaciarEliminados.Text = "Vaciar Eliminados";
            this.btnVaciarEliminados.UseVisualStyleBackColor = true;
            // 
            // FormEmpleadosEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVaciarEliminados);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.dgvEliminados);
            this.Name = "FormEmpleadosEliminados";
            this.Text = "FormEmpleadosEliminados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEliminados;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnVaciarEliminados;
    }
}