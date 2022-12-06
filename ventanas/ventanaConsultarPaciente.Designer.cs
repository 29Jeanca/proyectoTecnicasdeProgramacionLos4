namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaConsultarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaConsultarPaciente));
            this.combo_listaPacientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombrePaciente = new System.Windows.Forms.TextBox();
            this.txt_patologia = new System.Windows.Forms.TextBox();
            this.txt_estadoCivilPaciente = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_listaPacientes
            // 
            this.combo_listaPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_listaPacientes.FormattingEnabled = true;
            this.combo_listaPacientes.Location = new System.Drawing.Point(95, 105);
            this.combo_listaPacientes.Name = "combo_listaPacientes";
            this.combo_listaPacientes.Size = new System.Drawing.Size(133, 21);
            this.combo_listaPacientes.TabIndex = 0;
            this.combo_listaPacientes.SelectedIndexChanged += new System.EventHandler(this.combo_listaPacientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(123, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado Civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(26, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Patología";
            // 
            // txt_nombrePaciente
            // 
            this.txt_nombrePaciente.Enabled = false;
            this.txt_nombrePaciente.Location = new System.Drawing.Point(102, 196);
            this.txt_nombrePaciente.Name = "txt_nombrePaciente";
            this.txt_nombrePaciente.Size = new System.Drawing.Size(100, 20);
            this.txt_nombrePaciente.TabIndex = 5;
            // 
            // txt_patologia
            // 
            this.txt_patologia.Enabled = false;
            this.txt_patologia.Location = new System.Drawing.Point(102, 277);
            this.txt_patologia.Name = "txt_patologia";
            this.txt_patologia.Size = new System.Drawing.Size(100, 20);
            this.txt_patologia.TabIndex = 6;
            // 
            // txt_estadoCivilPaciente
            // 
            this.txt_estadoCivilPaciente.Enabled = false;
            this.txt_estadoCivilPaciente.Location = new System.Drawing.Point(102, 236);
            this.txt_estadoCivilPaciente.Name = "txt_estadoCivilPaciente";
            this.txt_estadoCivilPaciente.Size = new System.Drawing.Size(100, 20);
            this.txt_estadoCivilPaciente.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.button3.Location = new System.Drawing.Point(12, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 43);
            this.button3.TabIndex = 33;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ventanaConsultarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_estadoCivilPaciente);
            this.Controls.Add(this.txt_patologia);
            this.Controls.Add(this.txt_nombrePaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_listaPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaConsultarPaciente";
            this.Text = "Consultar Paciente";
            this.Load += new System.EventHandler(this.ventanaConsultarPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_listaPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombrePaciente;
        private System.Windows.Forms.TextBox txt_patologia;
        private System.Windows.Forms.TextBox txt_estadoCivilPaciente;
        private System.Windows.Forms.Button button3;
    }
}