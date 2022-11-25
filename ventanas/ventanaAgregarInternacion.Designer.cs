namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaAgregarInternacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectHospital = new System.Windows.Forms.ComboBox();
            this.selectPaciente = new System.Windows.Forms.ComboBox();
            this.Paciente = new System.Windows.Forms.Label();
            this.selectDoctor = new System.Windows.Forms.ComboBox();
            this.Doctor = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorContrato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital";
            // 
            // selectHospital
            // 
            this.selectHospital.FormattingEnabled = true;
            this.selectHospital.Location = new System.Drawing.Point(31, 49);
            this.selectHospital.Name = "selectHospital";
            this.selectHospital.Size = new System.Drawing.Size(121, 21);
            this.selectHospital.TabIndex = 1;
            // 
            // selectPaciente
            // 
            this.selectPaciente.FormattingEnabled = true;
            this.selectPaciente.Location = new System.Drawing.Point(31, 89);
            this.selectPaciente.Name = "selectPaciente";
            this.selectPaciente.Size = new System.Drawing.Size(121, 21);
            this.selectPaciente.TabIndex = 3;
            // 
            // Paciente
            // 
            this.Paciente.AutoSize = true;
            this.Paciente.Location = new System.Drawing.Point(28, 73);
            this.Paciente.Name = "Paciente";
            this.Paciente.Size = new System.Drawing.Size(49, 13);
            this.Paciente.TabIndex = 2;
            this.Paciente.Text = "Paciente";
            // 
            // selectDoctor
            // 
            this.selectDoctor.FormattingEnabled = true;
            this.selectDoctor.Location = new System.Drawing.Point(31, 129);
            this.selectDoctor.Name = "selectDoctor";
            this.selectDoctor.Size = new System.Drawing.Size(121, 21);
            this.selectDoctor.TabIndex = 5;
            this.selectDoctor.SelectedIndexChanged += new System.EventHandler(this.selectDoctor_SelectedIndexChanged);
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Location = new System.Drawing.Point(28, 113);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(39, 13);
            this.Doctor.TabIndex = 4;
            this.Doctor.Text = "Doctor";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(31, 171);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(262, 166);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor contrato";
            // 
            // txtValorContrato
            // 
            this.txtValorContrato.Location = new System.Drawing.Point(31, 356);
            this.txtValorContrato.Name = "txtValorContrato";
            this.txtValorContrato.Size = new System.Drawing.Size(138, 20);
            this.txtValorContrato.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Colones";
            // 
            // txtFechaContrato
            // 
            this.txtFechaContrato.Location = new System.Drawing.Point(31, 401);
            this.txtFechaContrato.Name = "txtFechaContrato";
            this.txtFechaContrato.Size = new System.Drawing.Size(200, 20);
            this.txtFechaContrato.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de contrato";
            // 
            // ventanaAgregarInternacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFechaContrato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorContrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.selectDoctor);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.selectPaciente);
            this.Controls.Add(this.Paciente);
            this.Controls.Add(this.selectHospital);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaAgregarInternacion";
            this.Text = "ventanaAgregarInternacion";
            this.Load += new System.EventHandler(this.ventanaAgregarInternacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectHospital;
        private System.Windows.Forms.ComboBox selectPaciente;
        private System.Windows.Forms.Label Paciente;
        private System.Windows.Forms.ComboBox selectDoctor;
        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorContrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtFechaContrato;
        private System.Windows.Forms.Label label5;
    }
}