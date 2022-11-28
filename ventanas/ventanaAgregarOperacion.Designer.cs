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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.input_FechaContrato = new System.Windows.Forms.DateTimePicker();
            this.txt_ValorContrato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_TipoCirugia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TipoCirugia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_IdPaciente
            // 
            this.combo_IdPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdPaciente.FormattingEnabled = true;
            this.combo_IdPaciente.Location = new System.Drawing.Point(31, 44);
            this.combo_IdPaciente.Name = "combo_IdPaciente";
            this.combo_IdPaciente.Size = new System.Drawing.Size(121, 21);
            this.combo_IdPaciente.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label1.Location = new System.Drawing.Point(28, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha del Contrato";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label2.Location = new System.Drawing.Point(28, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor Contrato";
            // 
            // combo_IdDoctor
            // 
            this.combo_IdDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdDoctor.FormattingEnabled = true;
            this.combo_IdDoctor.Location = new System.Drawing.Point(31, 102);
            this.combo_IdDoctor.Name = "combo_IdDoctor";
            this.combo_IdDoctor.Size = new System.Drawing.Size(121, 21);
            this.combo_IdDoctor.TabIndex = 11;
            this.combo_IdDoctor.SelectedIndexChanged += new System.EventHandler(this.combo_IdDoctor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label3.Location = new System.Drawing.Point(28, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Paciente";
            // 
            // combo_IdHospital
            // 
            this.combo_IdHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdHospital.FormattingEnabled = true;
            this.combo_IdHospital.Location = new System.Drawing.Point(31, 167);
            this.combo_IdHospital.Name = "combo_IdHospital";
            this.combo_IdHospital.Size = new System.Drawing.Size(121, 21);
            this.combo_IdHospital.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label4.Location = new System.Drawing.Point(28, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Cirugía";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.btnAgregar.Location = new System.Drawing.Point(175, 418);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.btnAtras.Location = new System.Drawing.Point(24, 418);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 23);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label5.Location = new System.Drawing.Point(28, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Hospital";
            // 
            // input_FechaContrato
            // 
            this.input_FechaContrato.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.input_FechaContrato.Location = new System.Drawing.Point(31, 373);
            this.input_FechaContrato.Name = "input_FechaContrato";
            this.input_FechaContrato.Size = new System.Drawing.Size(210, 21);
            this.input_FechaContrato.TabIndex = 3;
            // 
            // txt_ValorContrato
            // 
            this.txt_ValorContrato.Location = new System.Drawing.Point(31, 324);
            this.txt_ValorContrato.Name = "txt_ValorContrato";
            this.txt_ValorContrato.Size = new System.Drawing.Size(174, 20);
            this.txt_ValorContrato.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(361, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 23);
            this.label6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label7.Location = new System.Drawing.Point(28, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Doctor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label8.Location = new System.Drawing.Point(211, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Colones";
            // 
            // combo_TipoCirugia
            // 
            this.combo_TipoCirugia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_TipoCirugia.FormattingEnabled = true;
            this.combo_TipoCirugia.Items.AddRange(new object[] {
            "Rotura de ligamentos",
            "Cardiaca",
            "Vesicula",
            "Cerebral"});
            this.combo_TipoCirugia.Location = new System.Drawing.Point(31, 224);
            this.combo_TipoCirugia.Name = "combo_TipoCirugia";
            this.combo_TipoCirugia.Size = new System.Drawing.Size(121, 21);
            this.combo_TipoCirugia.TabIndex = 16;
            this.combo_TipoCirugia.SelectedIndexChanged += new System.EventHandler(this.combo_TipoCirugia_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label9.Location = new System.Drawing.Point(28, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo de Cirugía";
            // 
            // txt_TipoCirugia
            // 
            this.txt_TipoCirugia.Location = new System.Drawing.Point(31, 278);
            this.txt_TipoCirugia.Name = "txt_TipoCirugia";
            this.txt_TipoCirugia.Size = new System.Drawing.Size(167, 20);
            this.txt_TipoCirugia.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 22);
            this.button1.TabIndex = 19;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 20;
            // 
            // ventanaAgregarOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 456);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_TipoCirugia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_TipoCirugia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ValorContrato);
            this.Controls.Add(this.input_FechaContrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker input_FechaContrato;
        private System.Windows.Forms.TextBox txt_ValorContrato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_TipoCirugia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TipoCirugia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
    }
}