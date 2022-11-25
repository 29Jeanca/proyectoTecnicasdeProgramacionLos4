namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaAgregarVisitasPost
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
            this.combo_IdPaciente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_TipoChequeo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_EstadoHerida = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_IdDoctor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Medicamentos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.input_FechaVisita = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarVisitas = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número del hospital";
            // 
            // combo_IdHospital
            // 
            this.combo_IdHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdHospital.FormattingEnabled = true;
            this.combo_IdHospital.Location = new System.Drawing.Point(30, 57);
            this.combo_IdHospital.Name = "combo_IdHospital";
            this.combo_IdHospital.Size = new System.Drawing.Size(241, 23);
            this.combo_IdHospital.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificación del paciente";
            // 
            // combo_IdPaciente
            // 
            this.combo_IdPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdPaciente.FormattingEnabled = true;
            this.combo_IdPaciente.Location = new System.Drawing.Point(30, 125);
            this.combo_IdPaciente.Name = "combo_IdPaciente";
            this.combo_IdPaciente.Size = new System.Drawing.Size(241, 23);
            this.combo_IdPaciente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de chequeo";
            // 
            // combo_TipoChequeo
            // 
            this.combo_TipoChequeo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_TipoChequeo.FormattingEnabled = true;
            this.combo_TipoChequeo.Items.AddRange(new object[] {
            "Retiro de Puntos",
            "Chequeo"});
            this.combo_TipoChequeo.Location = new System.Drawing.Point(30, 197);
            this.combo_TipoChequeo.Name = "combo_TipoChequeo";
            this.combo_TipoChequeo.Size = new System.Drawing.Size(241, 23);
            this.combo_TipoChequeo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado de la herida";
            // 
            // combo_EstadoHerida
            // 
            this.combo_EstadoHerida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_EstadoHerida.FormattingEnabled = true;
            this.combo_EstadoHerida.Items.AddRange(new object[] {
            "Leve",
            "Moderado",
            "Grave"});
            this.combo_EstadoHerida.Location = new System.Drawing.Point(30, 274);
            this.combo_EstadoHerida.Name = "combo_EstadoHerida";
            this.combo_EstadoHerida.Size = new System.Drawing.Size(241, 23);
            this.combo_EstadoHerida.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Identificación del doctor";
            // 
            // combo_IdDoctor
            // 
            this.combo_IdDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdDoctor.FormattingEnabled = true;
            this.combo_IdDoctor.Location = new System.Drawing.Point(30, 350);
            this.combo_IdDoctor.Name = "combo_IdDoctor";
            this.combo_IdDoctor.Size = new System.Drawing.Size(241, 23);
            this.combo_IdDoctor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Medicamentos";
            // 
            // txt_Medicamentos
            // 
            this.txt_Medicamentos.Location = new System.Drawing.Point(30, 413);
            this.txt_Medicamentos.Multiline = true;
            this.txt_Medicamentos.Name = "txt_Medicamentos";
            this.txt_Medicamentos.Size = new System.Drawing.Size(198, 75);
            this.txt_Medicamentos.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 504);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de la visita";
            // 
            // input_FechaVisita
            // 
            this.input_FechaVisita.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_FechaVisita.Location = new System.Drawing.Point(30, 533);
            this.input_FechaVisita.Name = "input_FechaVisita";
            this.input_FechaVisita.Size = new System.Drawing.Size(236, 22);
            this.input_FechaVisita.TabIndex = 13;
            // 
            // btnAgregarVisitas
            // 
            this.btnAgregarVisitas.Location = new System.Drawing.Point(231, 577);
            this.btnAgregarVisitas.Name = "btnAgregarVisitas";
            this.btnAgregarVisitas.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarVisitas.TabIndex = 14;
            this.btnAgregarVisitas.Text = "Agregar";
            this.btnAgregarVisitas.UseVisualStyleBackColor = true;
            this.btnAgregarVisitas.Click += new System.EventHandler(this.btnAgregarVisitas_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 577);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 15;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // ventanaAgregarVisitasPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 610);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregarVisitas);
            this.Controls.Add(this.input_FechaVisita);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Medicamentos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_IdDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_EstadoHerida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_TipoChequeo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_IdPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_IdHospital);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaAgregarVisitasPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitas Post Operatorias";
            this.Load += new System.EventHandler(this.ventanaAgregarVisitasPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_IdHospital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_IdPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_TipoChequeo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_EstadoHerida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_IdDoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Medicamentos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker input_FechaVisita;
        private System.Windows.Forms.Button btnAgregarVisitas;
        private System.Windows.Forms.Button btnAtras;
    }
}