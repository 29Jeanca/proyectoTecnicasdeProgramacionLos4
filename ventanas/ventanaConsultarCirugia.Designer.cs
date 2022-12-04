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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaConsultarCirugia));
            this.label1 = new System.Windows.Forms.Label();
            this.combo_TipoCirugia = new System.Windows.Forms.ComboBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Paciente";
            // 
            // combo_TipoCirugia
            // 
            this.combo_TipoCirugia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_TipoCirugia.FormattingEnabled = true;
            this.combo_TipoCirugia.Location = new System.Drawing.Point(24, 84);
            this.combo_TipoCirugia.Name = "combo_TipoCirugia";
            this.combo_TipoCirugia.Size = new System.Drawing.Size(121, 21);
            this.combo_TipoCirugia.TabIndex = 7;
            this.combo_TipoCirugia.SelectedIndexChanged += new System.EventHandler(this.combo_TipoCirugia_SelectedIndexChanged_1);
            this.combo_TipoCirugia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.combo_TipoCirugia_MouseClick);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(24, 226);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(154, 20);
            this.txt_Nombre.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ventanaConsultarCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.combo_TipoCirugia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaConsultarCirugia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cirugia";
            this.Load += new System.EventHandler(this.ventanaConsultarCirugia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_TipoCirugia;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button button2;
    }
}