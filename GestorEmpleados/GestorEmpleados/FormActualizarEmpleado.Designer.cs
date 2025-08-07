namespace GestorEmpleados
{
    partial class FormActualizarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizarEmpleado));
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(334, 190);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 40);
            this.txtID.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(505, 185);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscar.Size = new System.Drawing.Size(132, 44);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salario:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 455);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(334, 246);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 40);
            this.txtNombre.TabIndex = 7;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(334, 347);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(239, 40);
            this.txtSueldo.TabIndex = 12;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(398, 449);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(463, 40);
            this.dtpFechaNacimiento.TabIndex = 13;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnActualizar.Font = new System.Drawing.Font("Constantia", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(449, 527);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(210, 90);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha de Inicio:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Items.AddRange(new object[] {
            "Administración",
            "IT",
            "",
            "Recursos Humanos",
            "",
            "Ventas",
            "Finanzas y Contabilidad",
            "",
            "Marketing",
            "",
            "Logística y Almacén",
            "",
            "Atención al Cliente",
            "",
            "Producción y Operaciones"});
            this.cmbDepartamento.Location = new System.Drawing.Point(334, 296);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(239, 41);
            this.cmbDepartamento.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(135, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 33);
            this.label9.TabIndex = 21;
            this.label9.Text = "Departamento:";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(715, 291);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(191, 40);
            this.txtCargo.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(715, 242);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(191, 40);
            this.txtApellido.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cargo:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(335, 399);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(526, 40);
            this.dtpFechaInicio.TabIndex = 16;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Vigente",
            "No Vigente"});
            this.cmbEstado.Location = new System.Drawing.Point(715, 343);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(191, 41);
            this.cmbEstado.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(600, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 33);
            this.label8.TabIndex = 19;
            this.label8.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(224, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(662, 78);
            this.label10.TabIndex = 22;
            this.label10.Text = "Actualizar Empleado";
            // 
            // FormActualizarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 695);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormActualizarEmpleado";
            this.Text = "Actualizar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}