namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaConsultarCirugia
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
            this.txt_Paciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Doctor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdHospital = new System.Windows.Forms.TextBox();
            this.combo_TipoCirugia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Paciente";
            // 
            // txt_Paciente
            // 
            this.txt_Paciente.Enabled = false;
            this.txt_Paciente.Location = new System.Drawing.Point(130, 103);
            this.txt_Paciente.Name = "txt_Paciente";
            this.txt_Paciente.Size = new System.Drawing.Size(162, 20);
            this.txt_Paciente.TabIndex = 2;
            this.txt_Paciente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Doctor";
            // 
            // txt_Doctor
            // 
            this.txt_Doctor.Enabled = false;
            this.txt_Doctor.Location = new System.Drawing.Point(130, 167);
            this.txt_Doctor.Name = "txt_Doctor";
            this.txt_Doctor.Size = new System.Drawing.Size(162, 20);
            this.txt_Doctor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Hospital";
            // 
            // txt_IdHospital
            // 
            this.txt_IdHospital.Enabled = false;
            this.txt_IdHospital.Location = new System.Drawing.Point(130, 230);
            this.txt_IdHospital.Name = "txt_IdHospital";
            this.txt_IdHospital.Size = new System.Drawing.Size(162, 20);
            this.txt_IdHospital.TabIndex = 6;
            // 
            // combo_TipoCirugia
            // 
            this.combo_TipoCirugia.FormattingEnabled = true;
            this.combo_TipoCirugia.Location = new System.Drawing.Point(24, 27);
            this.combo_TipoCirugia.Name = "combo_TipoCirugia";
            this.combo_TipoCirugia.Size = new System.Drawing.Size(121, 21);
            this.combo_TipoCirugia.TabIndex = 7;
            this.combo_TipoCirugia.SelectedIndexChanged += new System.EventHandler(this.combo_TipoCirugia_SelectedIndexChanged_1);
            // 
            // ventanaConsultarCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.combo_TipoCirugia);
            this.Controls.Add(this.txt_IdHospital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Doctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Paciente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaConsultarCirugia";
            this.Text = "Consulta Cirugia";
            this.Load += new System.EventHandler(this.ventanaConsultarCirugia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Paciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Doctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdHospital;
        private System.Windows.Forms.ComboBox combo_TipoCirugia;
    }
}