namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaAgregarInternacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAgregarInternacion));
            this.label1 = new System.Windows.Forms.Label();
            this.selectHospital = new System.Windows.Forms.ComboBox();
            this.selectPaciente = new System.Windows.Forms.ComboBox();
            this.LABBEL = new System.Windows.Forms.Label();
            this.selectDoctor = new System.Windows.Forms.ComboBox();
            this.Doctor = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorContrato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(201, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital";
            // 
            // selectHospital
            // 
            this.selectHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectHospital.FormattingEnabled = true;
            this.selectHospital.Location = new System.Drawing.Point(204, 24);
            this.selectHospital.Name = "selectHospital";
            this.selectHospital.Size = new System.Drawing.Size(121, 21);
            this.selectHospital.TabIndex = 1;
            this.selectHospital.SelectedIndexChanged += new System.EventHandler(this.selectHospital_SelectedIndexChanged);
            // 
            // selectPaciente
            // 
            this.selectPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPaciente.FormattingEnabled = true;
            this.selectPaciente.Location = new System.Drawing.Point(204, 66);
            this.selectPaciente.Name = "selectPaciente";
            this.selectPaciente.Size = new System.Drawing.Size(121, 21);
            this.selectPaciente.TabIndex = 3;
            // 
            // LABBEL
            // 
            this.LABBEL.AutoSize = true;
            this.LABBEL.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.LABBEL.ForeColor = System.Drawing.SystemColors.Control;
            this.LABBEL.Location = new System.Drawing.Point(201, 48);
            this.LABBEL.Name = "LABBEL";
            this.LABBEL.Size = new System.Drawing.Size(51, 15);
            this.LABBEL.TabIndex = 2;
            this.LABBEL.Text = "Paciente";
            // 
            // selectDoctor
            // 
            this.selectDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDoctor.FormattingEnabled = true;
            this.selectDoctor.Location = new System.Drawing.Point(204, 113);
            this.selectDoctor.Name = "selectDoctor";
            this.selectDoctor.Size = new System.Drawing.Size(121, 21);
            this.selectDoctor.TabIndex = 5;
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.Doctor.ForeColor = System.Drawing.SystemColors.Control;
            this.Doctor.Location = new System.Drawing.Point(201, 94);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(42, 15);
            this.Doctor.TabIndex = 4;
            this.Doctor.Text = "Doctor";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(204, 161);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(191, 138);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(201, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.button1.Location = new System.Drawing.Point(205, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(202, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor contrato";
            // 
            // txtValorContrato
            // 
            this.txtValorContrato.Location = new System.Drawing.Point(204, 327);
            this.txtValorContrato.Name = "txtValorContrato";
            this.txtValorContrato.Size = new System.Drawing.Size(138, 20);
            this.txtValorContrato.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(348, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Colones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 509);
            this.panel1.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(194)))));
            this.button3.Location = new System.Drawing.Point(7, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 43);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ventanaAgregarInternacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(416, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorContrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.selectDoctor);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.selectPaciente);
            this.Controls.Add(this.LABBEL);
            this.Controls.Add(this.selectHospital);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaAgregarInternacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Internacion";
            this.Load += new System.EventHandler(this.ventanaAgregarInternacion_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectHospital;
        private System.Windows.Forms.ComboBox selectPaciente;
        private System.Windows.Forms.Label LABBEL;
        private System.Windows.Forms.ComboBox selectDoctor;
        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorContrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}