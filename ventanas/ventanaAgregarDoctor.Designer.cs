namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaAgregarDoctor
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
            this.combo_IdHospital = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreDoctor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ApellidoDoctor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CorreoDoctor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TelefonoDoctor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_EstadoCivil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_EspecialidadDoctor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_GradoAcademico = new System.Windows.Forms.ComboBox();
            this.btnAgregarDoctor = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital ";
            // 
            // combo_IdHospital
            // 
            this.combo_IdHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdHospital.FormattingEnabled = true;
            this.combo_IdHospital.Location = new System.Drawing.Point(12, 50);
            this.combo_IdHospital.Name = "combo_IdHospital";
            this.combo_IdHospital.Size = new System.Drawing.Size(121, 21);
            this.combo_IdHospital.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del doctor";
            // 
            // txt_NombreDoctor
            // 
            this.txt_NombreDoctor.Location = new System.Drawing.Point(12, 113);
            this.txt_NombreDoctor.Name = "txt_NombreDoctor";
            this.txt_NombreDoctor.Size = new System.Drawing.Size(198, 20);
            this.txt_NombreDoctor.TabIndex = 3;
            this.txt_NombreDoctor.TextChanged += new System.EventHandler(this.txt_NombreDoctor_TextChanged);
            this.txt_NombreDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreDoctor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido del doctor";
            // 
            // txt_ApellidoDoctor
            // 
            this.txt_ApellidoDoctor.Location = new System.Drawing.Point(12, 166);
            this.txt_ApellidoDoctor.Name = "txt_ApellidoDoctor";
            this.txt_ApellidoDoctor.Size = new System.Drawing.Size(198, 20);
            this.txt_ApellidoDoctor.TabIndex = 5;
            this.txt_ApellidoDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ApellidoDoctor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo del doctor";
            // 
            // txt_CorreoDoctor
            // 
            this.txt_CorreoDoctor.Location = new System.Drawing.Point(12, 218);
            this.txt_CorreoDoctor.Name = "txt_CorreoDoctor";
            this.txt_CorreoDoctor.Size = new System.Drawing.Size(198, 20);
            this.txt_CorreoDoctor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label5.Location = new System.Drawing.Point(9, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono del doctor";
            // 
            // txt_TelefonoDoctor
            // 
            this.txt_TelefonoDoctor.Location = new System.Drawing.Point(12, 270);
            this.txt_TelefonoDoctor.Name = "txt_TelefonoDoctor";
            this.txt_TelefonoDoctor.Size = new System.Drawing.Size(198, 20);
            this.txt_TelefonoDoctor.TabIndex = 9;
            this.txt_TelefonoDoctor.TextChanged += new System.EventHandler(this.txt_TelefonoDoctor_TextChanged);
            this.txt_TelefonoDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TelefonoDoctor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label6.Location = new System.Drawing.Point(9, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado civil del doctor";
            // 
            // combo_EstadoCivil
            // 
            this.combo_EstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_EstadoCivil.FormattingEnabled = true;
            this.combo_EstadoCivil.Items.AddRange(new object[] {
            "Casado ",
            "Soltero",
            "Viudo"});
            this.combo_EstadoCivil.Location = new System.Drawing.Point(12, 321);
            this.combo_EstadoCivil.Name = "combo_EstadoCivil";
            this.combo_EstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.combo_EstadoCivil.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label7.Location = new System.Drawing.Point(12, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label8.Location = new System.Drawing.Point(12, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Especialidad del doctor";
            // 
            // combo_EspecialidadDoctor
            // 
            this.combo_EspecialidadDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_EspecialidadDoctor.FormattingEnabled = true;
            this.combo_EspecialidadDoctor.Items.AddRange(new object[] {
            "Cirujano",
            "Medico general"});
            this.combo_EspecialidadDoctor.Location = new System.Drawing.Point(12, 382);
            this.combo_EspecialidadDoctor.Name = "combo_EspecialidadDoctor";
            this.combo_EspecialidadDoctor.Size = new System.Drawing.Size(121, 21);
            this.combo_EspecialidadDoctor.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label10.Location = new System.Drawing.Point(9, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Grado Acádemico del doctor";
            // 
            // combo_GradoAcademico
            // 
            this.combo_GradoAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_GradoAcademico.FormattingEnabled = true;
            this.combo_GradoAcademico.Items.AddRange(new object[] {
            "Doctorado"});
            this.combo_GradoAcademico.Location = new System.Drawing.Point(12, 440);
            this.combo_GradoAcademico.Name = "combo_GradoAcademico";
            this.combo_GradoAcademico.Size = new System.Drawing.Size(121, 21);
            this.combo_GradoAcademico.TabIndex = 17;
            // 
            // btnAgregarDoctor
            // 
            this.btnAgregarDoctor.Location = new System.Drawing.Point(207, 480);
            this.btnAgregarDoctor.Name = "btnAgregarDoctor";
            this.btnAgregarDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDoctor.TabIndex = 18;
            this.btnAgregarDoctor.Text = "Agregar";
            this.btnAgregarDoctor.UseVisualStyleBackColor = true;
            this.btnAgregarDoctor.Click += new System.EventHandler(this.btnAgregarDoctor_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 479);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 19;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // ventanaAgregarDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 518);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregarDoctor);
            this.Controls.Add(this.combo_GradoAcademico);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_EspecialidadDoctor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combo_EstadoCivil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TelefonoDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CorreoDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ApellidoDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NombreDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_IdHospital);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaAgregarDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Doctor";
            this.Load += new System.EventHandler(this.ventanaAgregarDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_IdHospital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ApellidoDoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CorreoDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TelefonoDoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_EstadoCivil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_EspecialidadDoctor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_GradoAcademico;
        private System.Windows.Forms.Button btnAgregarDoctor;
        private System.Windows.Forms.Button btnAtras;
    }
}