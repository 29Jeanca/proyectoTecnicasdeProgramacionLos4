namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarHospitales = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarVisita = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 108);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ventana agregar Hospitales";
            // 
            // btnAgregarHospitales
            // 
            this.btnAgregarHospitales.Location = new System.Drawing.Point(89, 61);
            this.btnAgregarHospitales.Name = "btnAgregarHospitales";
            this.btnAgregarHospitales.Size = new System.Drawing.Size(118, 55);
            this.btnAgregarHospitales.TabIndex = 2;
            this.btnAgregarHospitales.Text = "Agregar Hospitales";
            this.btnAgregarHospitales.UseVisualStyleBackColor = true;
            this.btnAgregarHospitales.Click += new System.EventHandler(this.btnAgregarDoctor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ventana agregar Visita Post Operatoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarVisita
            // 
            this.btnAgregarVisita.Location = new System.Drawing.Point(90, 198);
            this.btnAgregarVisita.Name = "btnAgregarVisita";
            this.btnAgregarVisita.Size = new System.Drawing.Size(118, 55);
            this.btnAgregarVisita.TabIndex = 4;
            this.btnAgregarVisita.Text = "Agregar Visita Post Operatoria";
            this.btnAgregarVisita.UseVisualStyleBackColor = true;
            this.btnAgregarVisita.Click += new System.EventHandler(this.btnAgregarVisita_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ventana agregar Doctor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarDoctor
            // 
            this.btnAgregarDoctor.Location = new System.Drawing.Point(89, 322);
            this.btnAgregarDoctor.Name = "btnAgregarDoctor";
            this.btnAgregarDoctor.Size = new System.Drawing.Size(118, 55);
            this.btnAgregarDoctor.TabIndex = 6;
            this.btnAgregarDoctor.Text = "Agregar Doctor";
            this.btnAgregarDoctor.UseVisualStyleBackColor = true;
            this.btnAgregarDoctor.Click += new System.EventHandler(this.btnAgregarDoctor_Click_1);
            // 
            // ventanaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.btnAgregarDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarVisita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarHospitales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaMenu";
            this.Text = "ventanaMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarHospitales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarVisita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarDoctor;
    }
}