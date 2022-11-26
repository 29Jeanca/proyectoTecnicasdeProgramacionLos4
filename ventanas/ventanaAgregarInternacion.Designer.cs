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
            this.LABBEL = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital";
            // 
            // selectHospital
            // 
            this.selectHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectHospital.FormattingEnabled = true;
            this.selectHospital.Location = new System.Drawing.Point(31, 36);
            this.selectHospital.Name = "selectHospital";
            this.selectHospital.Size = new System.Drawing.Size(121, 21);
            this.selectHospital.TabIndex = 1;
            // 
            // selectPaciente
            // 
            this.selectPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPaciente.FormattingEnabled = true;
            this.selectPaciente.Location = new System.Drawing.Point(31, 78);
            this.selectPaciente.Name = "selectPaciente";
            this.selectPaciente.Size = new System.Drawing.Size(121, 21);
            this.selectPaciente.TabIndex = 3;
            // 
            // LABBEL
            // 
            this.LABBEL.AutoSize = true;
            this.LABBEL.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.LABBEL.Location = new System.Drawing.Point(28, 60);
            this.LABBEL.Name = "LABBEL";
            this.LABBEL.Size = new System.Drawing.Size(51, 15);
            this.LABBEL.TabIndex = 2;
            this.LABBEL.Text = "Paciente";
            // 
            // selectDoctor
            // 
            this.selectDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDoctor.FormattingEnabled = true;
            this.selectDoctor.Location = new System.Drawing.Point(31, 125);
            this.selectDoctor.Name = "selectDoctor";
            this.selectDoctor.Size = new System.Drawing.Size(121, 21);
            this.selectDoctor.TabIndex = 5;
            this.selectDoctor.SelectedIndexChanged += new System.EventHandler(this.selectDoctor_SelectedIndexChanged);
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.Doctor.Location = new System.Drawing.Point(28, 106);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(42, 15);
            this.Doctor.TabIndex = 4;
            this.Doctor.Text = "Doctor";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(31, 173);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(262, 138);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.button1.Location = new System.Drawing.Point(178, 442);
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
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label3.Location = new System.Drawing.Point(29, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor contrato";
            // 
            // txtValorContrato
            // 
            this.txtValorContrato.Location = new System.Drawing.Point(31, 339);
            this.txtValorContrato.Name = "txtValorContrato";
            this.txtValorContrato.Size = new System.Drawing.Size(138, 20);
            this.txtValorContrato.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label4.Location = new System.Drawing.Point(175, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Colones";
            // 
            // txtFechaContrato
            // 
            this.txtFechaContrato.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.txtFechaContrato.Location = new System.Drawing.Point(31, 391);
            this.txtFechaContrato.Name = "txtFechaContrato";
            this.txtFechaContrato.Size = new System.Drawing.Size(225, 21);
            this.txtFechaContrato.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label5.Location = new System.Drawing.Point(28, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de contrato";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.button2.Location = new System.Drawing.Point(49, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ventanaAgregarInternacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 506);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.LABBEL);
            this.Controls.Add(this.selectHospital);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaAgregarInternacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Internacion";
            this.Load += new System.EventHandler(this.ventanaAgregarInternacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectHospital;
        private System.Windows.Forms.ComboBox selectPaciente;
        private System.Windows.Forms.Label LABBEL;
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
        private System.Windows.Forms.Button button2;
    }
}