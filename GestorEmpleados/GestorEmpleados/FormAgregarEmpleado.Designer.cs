namespace GestorEmpleados
{
    partial class FormAgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarEmpleado));
            this.tbIDempleado = new System.Windows.Forms.TextBox();
            this.lblIDempleado = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblSalarioError = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblARS = new System.Windows.Forms.Label();
            this.lblTiempoEmpresa = new System.Windows.Forms.Label();
            this.lblISR = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbIDempleado
            // 
            this.tbIDempleado.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDempleado.Location = new System.Drawing.Point(268, 175);
            this.tbIDempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIDempleado.Name = "tbIDempleado";
            this.tbIDempleado.Size = new System.Drawing.Size(72, 40);
            this.tbIDempleado.TabIndex = 0;
            // 
            // lblIDempleado
            // 
            this.lblIDempleado.AutoSize = true;
            this.lblIDempleado.BackColor = System.Drawing.Color.Transparent;
            this.lblIDempleado.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDempleado.Location = new System.Drawing.Point(65, 182);
            this.lblIDempleado.Name = "lblIDempleado";
            this.lblIDempleado.Size = new System.Drawing.Size(176, 33);
            this.lblIDempleado.TabIndex = 1;
            this.lblIDempleado.Text = "ID Empleado:";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(346, 182);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(118, 33);
            this.lblNombreEmpleado.TabIndex = 2;
            this.lblNombreEmpleado.Text = "Nombre:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartamento.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(65, 226);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(193, 33);
            this.lblDepartamento.TabIndex = 3;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(718, 226);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(91, 33);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(65, 273);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(197, 33);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // lblSalarioError
            // 
            this.lblSalarioError.AutoSize = true;
            this.lblSalarioError.BackColor = System.Drawing.Color.Transparent;
            this.lblSalarioError.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioError.Location = new System.Drawing.Point(65, 324);
            this.lblSalarioError.Name = "lblSalarioError";
            this.lblSalarioError.Size = new System.Drawing.Size(103, 33);
            this.lblSalarioError.TabIndex = 6;
            this.lblSalarioError.Text = "Salario:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(470, 175);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(292, 40);
            this.tbNombre.TabIndex = 8;
            // 
            // tbCargo
            // 
            this.tbCargo.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCargo.Location = new System.Drawing.Point(815, 223);
            this.tbCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(459, 40);
            this.tbCargo.TabIndex = 9;
            // 
            // tbSalario
            // 
            this.tbSalario.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalario.Location = new System.Drawing.Point(268, 324);
            this.tbSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(427, 40);
            this.tbSalario.TabIndex = 10;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(268, 223);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(427, 41);
            this.cmbDepartamento.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(687, 429);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(102, 33);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(788, 421);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(316, 41);
            this.cmbEstado.TabIndex = 13;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(268, 273);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(407, 40);
            this.dtpFechaInicio.TabIndex = 14;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEmpleado.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(1322, 175);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(181, 90);
            this.btnEmpleado.TabIndex = 18;
            this.btnEmpleado.Text = "Guardar Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1322, 296);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 88);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(711, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "ARS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "AFP: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 33);
            this.label3.TabIndex = 22;
            this.label3.Text = "ISR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tiempo en la Empresa:";
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAFP.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFP.Location = new System.Drawing.Point(384, 375);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(64, 33);
            this.lblAFP.TabIndex = 15;
            this.lblAFP.Text = "AFP";
            // 
            // lblARS
            // 
            this.lblARS.AutoSize = true;
            this.lblARS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblARS.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARS.Location = new System.Drawing.Point(790, 374);
            this.lblARS.Name = "lblARS";
            this.lblARS.Size = new System.Drawing.Size(64, 33);
            this.lblARS.TabIndex = 16;
            this.lblARS.Text = "ARS";
            // 
            // lblTiempoEmpresa
            // 
            this.lblTiempoEmpresa.AutoSize = true;
            this.lblTiempoEmpresa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTiempoEmpresa.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoEmpresa.Location = new System.Drawing.Point(360, 429);
            this.lblTiempoEmpresa.Name = "lblTiempoEmpresa";
            this.lblTiempoEmpresa.Size = new System.Drawing.Size(271, 33);
            this.lblTiempoEmpresa.TabIndex = 7;
            this.lblTiempoEmpresa.Text = "Tiempo en la empresa";
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblISR.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISR.Location = new System.Drawing.Point(592, 375);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(55, 33);
            this.lblISR.TabIndex = 17;
            this.lblISR.Text = "ISR";
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(908, 175);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4);
            this.tbApellido.Multiline = true;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(367, 40);
            this.tbApellido.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(777, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 33);
            this.label5.TabIndex = 25;
            this.label5.Text = "Apellido:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(959, 273);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(314, 40);
            this.dtpFechaNacimiento.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(687, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 33);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 33);
            this.label7.TabIndex = 28;
            this.label7.Text = "Descuentos:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Constantia", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(480, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(624, 79);
            this.label8.TabIndex = 29;
            this.label8.Text = "Agregar Empleado";
            // 
            // FormAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1552, 570);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.lblISR);
            this.Controls.Add(this.lblARS);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbCargo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblTiempoEmpresa);
            this.Controls.Add(this.lblSalarioError);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.lblIDempleado);
            this.Controls.Add(this.tbIDempleado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAgregarEmpleado";
            this.Text = "Agregar Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAgregarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIDempleado;
        private System.Windows.Forms.Label lblIDempleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblSalarioError;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.Label lblARS;
        private System.Windows.Forms.Label lblTiempoEmpresa;
        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}