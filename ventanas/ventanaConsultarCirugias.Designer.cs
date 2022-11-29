namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaConsultarCirugias
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
            this.combo_ConsultarCirugias = new System.Windows.Forms.ComboBox();
            this.prueba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // combo_ConsultarCirugias
            // 
            this.combo_ConsultarCirugias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ConsultarCirugias.FormattingEnabled = true;
            this.combo_ConsultarCirugias.Location = new System.Drawing.Point(12, 12);
            this.combo_ConsultarCirugias.Name = "combo_ConsultarCirugias";
            this.combo_ConsultarCirugias.Size = new System.Drawing.Size(121, 21);
            this.combo_ConsultarCirugias.TabIndex = 4;
            this.combo_ConsultarCirugias.SelectedIndexChanged += new System.EventHandler(this.combo_ConsultarCirugias_SelectedIndexChanged);
            // 
            // prueba
            // 
            this.prueba.Location = new System.Drawing.Point(65, 272);
            this.prueba.Multiline = true;
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(206, 115);
            this.prueba.TabIndex = 5;
            // 
            // ventanaConsultarCirugias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.combo_ConsultarCirugias);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaConsultarCirugias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cirugías";
            this.Load += new System.EventHandler(this.ventanaConsultarCirugias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_ConsultarCirugias;
        private System.Windows.Forms.TextBox prueba;
    }
}