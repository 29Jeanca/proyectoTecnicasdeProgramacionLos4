namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaAgregarOperacion
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
            this.combo_IdPaciente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_IdDoctor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_IdHospital = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DescripcionOperacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.input_FechaContrato = new System.Windows.Forms.DateTimePicker();
            this.txt_ValorContrato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_IdPaciente
            // 
            this.combo_IdPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdPaciente.FormattingEnabled = true;
            this.combo_IdPaciente.Location = new System.Drawing.Point(117, 38);
            this.combo_IdPaciente.Name = "combo_IdPaciente";
            this.combo_IdPaciente.Size = new System.Drawing.Size(164, 21);
            this.combo_IdPaciente.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(191, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(233, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 12;
            // 
            // combo_IdDoctor
            // 
            this.combo_IdDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdDoctor.FormattingEnabled = true;
            this.combo_IdDoctor.Location = new System.Drawing.Point(93, 94);
            this.combo_IdDoctor.Name = "combo_IdDoctor";
            this.combo_IdDoctor.Size = new System.Drawing.Size(164, 21);
            this.combo_IdDoctor.TabIndex = 11;
            this.combo_IdDoctor.SelectedIndexChanged += new System.EventHandler(this.combo_IdDoctor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(248, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 10;
            // 
            // combo_IdHospital
            // 
            this.combo_IdHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdHospital.FormattingEnabled = true;
            this.combo_IdHospital.Location = new System.Drawing.Point(12, 257);
            this.combo_IdHospital.Name = "combo_IdHospital";
            this.combo_IdHospital.Size = new System.Drawing.Size(121, 21);
            this.combo_IdHospital.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            // 
            // txt_DescripcionOperacion
            // 
            this.txt_DescripcionOperacion.Location = new System.Drawing.Point(-13, 103);
            this.txt_DescripcionOperacion.Name = "txt_DescripcionOperacion";
            this.txt_DescripcionOperacion.Size = new System.Drawing.Size(100, 20);
            this.txt_DescripcionOperacion.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(46, 65);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(46, 100);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            // 
            // input_FechaContrato
            // 
            this.input_FechaContrato.Location = new System.Drawing.Point(12, 231);
            this.input_FechaContrato.Name = "input_FechaContrato";
            this.input_FechaContrato.Size = new System.Drawing.Size(200, 20);
            this.input_FechaContrato.TabIndex = 3;
            // 
            // txt_ValorContrato
            // 
            this.txt_ValorContrato.Location = new System.Drawing.Point(0, 94);
            this.txt_ValorContrato.Name = "txt_ValorContrato";
            this.txt_ValorContrato.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorContrato.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(21, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(21, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // ventanaAgregarOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(561, 437);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ValorContrato);
            this.Controls.Add(this.input_FechaContrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txt_DescripcionOperacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_IdHospital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_IdDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_IdPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaAgregarOperacion";
            this.Load += new System.EventHandler(this.ventanaAgregarOperacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_IdPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_IdDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_IdHospital;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DescripcionOperacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker input_FechaContrato;
        private System.Windows.Forms.TextBox txt_ValorContrato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}