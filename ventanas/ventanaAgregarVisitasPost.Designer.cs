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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAgregarVisitasPost));
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
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(243, 9);
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
            this.combo_IdHospital.Location = new System.Drawing.Point(246, 27);
            this.combo_IdHospital.Name = "combo_IdHospital";
            this.combo_IdHospital.Size = new System.Drawing.Size(194, 23);
            this.combo_IdHospital.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(243, 67);
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
            this.combo_IdPaciente.Location = new System.Drawing.Point(246, 85);
            this.combo_IdPaciente.Name = "combo_IdPaciente";
            this.combo_IdPaciente.Size = new System.Drawing.Size(194, 23);
            this.combo_IdPaciente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(243, 122);
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
            this.combo_TipoChequeo.Location = new System.Drawing.Point(246, 140);
            this.combo_TipoChequeo.Name = "combo_TipoChequeo";
            this.combo_TipoChequeo.Size = new System.Drawing.Size(194, 23);
            this.combo_TipoChequeo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(244, 177);
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
            this.combo_EstadoHerida.Location = new System.Drawing.Point(246, 195);
            this.combo_EstadoHerida.Name = "combo_EstadoHerida";
            this.combo_EstadoHerida.Size = new System.Drawing.Size(193, 23);
            this.combo_EstadoHerida.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(244, 232);
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
            this.combo_IdDoctor.Location = new System.Drawing.Point(246, 252);
            this.combo_IdDoctor.Name = "combo_IdDoctor";
            this.combo_IdDoctor.Size = new System.Drawing.Size(198, 23);
            this.combo_IdDoctor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(244, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Medicamentos";
            // 
            // txt_Medicamentos
            // 
            this.txt_Medicamentos.Location = new System.Drawing.Point(247, 311);
            this.txt_Medicamentos.Name = "txt_Medicamentos";
            this.txt_Medicamentos.Size = new System.Drawing.Size(197, 21);
            this.txt_Medicamentos.TabIndex = 11;
            this.txt_Medicamentos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Medicamentos_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(244, 407);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de la visita";
            // 
            // input_FechaVisita
            // 
            this.input_FechaVisita.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_FechaVisita.Location = new System.Drawing.Point(247, 434);
            this.input_FechaVisita.Name = "input_FechaVisita";
            this.input_FechaVisita.Size = new System.Drawing.Size(197, 22);
            this.input_FechaVisita.TabIndex = 13;
            // 
            // btnAgregarVisitas
            // 
            this.btnAgregarVisitas.Location = new System.Drawing.Point(247, 477);
            this.btnAgregarVisitas.Name = "btnAgregarVisitas";
            this.btnAgregarVisitas.Size = new System.Drawing.Size(197, 23);
            this.btnAgregarVisitas.TabIndex = 14;
            this.btnAgregarVisitas.Text = "Agregar";
            this.btnAgregarVisitas.UseVisualStyleBackColor = true;
            this.btnAgregarVisitas.Click += new System.EventHandler(this.btnAgregarVisitas_Click);
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(247, 369);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(197, 21);
            this.txtGasto.TabIndex = 16;
            this.txtGasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGasto_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(244, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Gastos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(451, 372);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Colones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 536);
            this.panel1.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(194)))));
            this.button2.Location = new System.Drawing.Point(11, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ventanaAgregarVisitasPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(507, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGasto);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}