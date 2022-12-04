namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaAgregarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAgregarPago));
            this.selectHospital = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectPaciente = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.combo_TipoCirugia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOtraCirugia = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectHospital
            // 
            this.selectHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectHospital.FormattingEnabled = true;
            this.selectHospital.Location = new System.Drawing.Point(195, 25);
            this.selectHospital.Name = "selectHospital";
            this.selectHospital.Size = new System.Drawing.Size(136, 21);
            this.selectHospital.TabIndex = 0;
            this.selectHospital.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital";
        
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(195, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paciente";
            // 
            // selectPaciente
            // 
            this.selectPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPaciente.FormattingEnabled = true;
            this.selectPaciente.Location = new System.Drawing.Point(195, 67);
            this.selectPaciente.Name = "selectPaciente";
            this.selectPaciente.Size = new System.Drawing.Size(136, 21);
            this.selectPaciente.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(195, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 20);
            this.txtNombre.TabIndex = 4;
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(195, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            
            // label4
      
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(195, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(195, 150);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(136, 20);
            this.txtApellido.TabIndex = 7;
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(195, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pago";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(195, 277);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(139, 20);
            this.txtPago.TabIndex = 9;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(360, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Colones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_TipoCirugia
            // 
            this.combo_TipoCirugia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_TipoCirugia.FormattingEnabled = true;
            this.combo_TipoCirugia.Items.AddRange(new object[] {
            "Rotura de ligamentos",
            "Rotura de miembro",
            "Vesicula",
            "Cerebral"});
            this.combo_TipoCirugia.Location = new System.Drawing.Point(195, 195);
            this.combo_TipoCirugia.Name = "combo_TipoCirugia";
            this.combo_TipoCirugia.Size = new System.Drawing.Size(136, 21);
            this.combo_TipoCirugia.TabIndex = 16;
            this.combo_TipoCirugia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(195, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo de cirugia";
  
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(195, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Otra cirugia";
        
            // 
            // txtOtraCirugia
            // 
            this.txtOtraCirugia.Location = new System.Drawing.Point(195, 238);
            this.txtOtraCirugia.Name = "txtOtraCirugia";
            this.txtOtraCirugia.Size = new System.Drawing.Size(139, 20);
            this.txtOtraCirugia.TabIndex = 19;
            
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-16, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 371);
            this.panel1.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(194)))));
            this.button2.Location = new System.Drawing.Point(19, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ventanaAgregarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(419, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtOtraCirugia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_TipoCirugia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectHospital);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaAgregarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventanaAgregarPago";
            this.Load += new System.EventHandler(this.ventanaAgregarPago_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectHospital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectPaciente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_TipoCirugia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOtraCirugia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}