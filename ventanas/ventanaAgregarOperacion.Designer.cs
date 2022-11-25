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
            this.combo_IdPaciente.Location = new System.Drawing.Point(31, 44);
            this.combo_IdPaciente.Name = "combo_IdPaciente";
            this.combo_IdPaciente.Size = new System.Drawing.Size(192, 21);
            this.combo_IdPaciente.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha del Contrato";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor Contrato";
            // 
            // combo_IdDoctor
            // 
            this.combo_IdDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdDoctor.FormattingEnabled = true;
            this.combo_IdDoctor.Location = new System.Drawing.Point(31, 111);
            this.combo_IdDoctor.Name = "combo_IdDoctor";
            this.combo_IdDoctor.Size = new System.Drawing.Size(192, 21);
            this.combo_IdDoctor.TabIndex = 11;
            this.combo_IdDoctor.SelectedIndexChanged += new System.EventHandler(this.combo_IdDoctor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Paciente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // combo_IdHospital
            // 
            this.combo_IdHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdHospital.FormattingEnabled = true;
            this.combo_IdHospital.Location = new System.Drawing.Point(31, 174);
            this.combo_IdHospital.Name = "combo_IdHospital";
            this.combo_IdHospital.Size = new System.Drawing.Size(192, 21);
            this.combo_IdHospital.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripcion de la Operación";
            // 
            // txt_DescripcionOperacion
            // 
            this.txt_DescripcionOperacion.Location = new System.Drawing.Point(31, 242);
            this.txt_DescripcionOperacion.Multiline = true;
            this.txt_DescripcionOperacion.Name = "txt_DescripcionOperacion";
            this.txt_DescripcionOperacion.Size = new System.Drawing.Size(169, 84);
            this.txt_DescripcionOperacion.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(238, 478);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 478);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 23);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(28, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Hospital";
            // 
            // input_FechaContrato
            // 
            this.input_FechaContrato.Location = new System.Drawing.Point(31, 431);
            this.input_FechaContrato.Name = "input_FechaContrato";
            this.input_FechaContrato.Size = new System.Drawing.Size(263, 20);
            this.input_FechaContrato.TabIndex = 3;
            // 
            // txt_ValorContrato
            // 
            this.txt_ValorContrato.Location = new System.Drawing.Point(31, 367);
            this.txt_ValorContrato.Name = "txt_ValorContrato";
            this.txt_ValorContrato.Size = new System.Drawing.Size(205, 20);
            this.txt_ValorContrato.TabIndex = 2;
            this.txt_ValorContrato.TextChanged += new System.EventHandler(this.txt_ValorContrato_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(361, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 23);
            this.label6.TabIndex = 1;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(28, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Doctor";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ventanaAgregarOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(338, 516);
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
            this.Text = "Agregar Operaciones";
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