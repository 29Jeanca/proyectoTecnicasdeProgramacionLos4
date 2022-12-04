namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class VentanaConsultarInternacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaConsultarInternacion));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labbelName = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.Label();
            this.labbleCorreo = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textEstadoCivil = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textHospital = new System.Windows.Forms.Label();
            this.labelHospital = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Card.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labbelName
            // 
            this.labbelName.AutoSize = true;
            this.labbelName.Location = new System.Drawing.Point(51, 29);
            this.labbelName.Name = "labbelName";
            this.labbelName.Size = new System.Drawing.Size(94, 13);
            this.labbelName.TabIndex = 2;
            this.labbelName.Text = "Nombre Completo:";
            this.labbelName.Visible = false;
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(151, 29);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(35, 13);
            this.textNombre.TabIndex = 3;
            this.textNombre.Text = "label2";
            this.textNombre.Visible = false;
            // 
            // textCorreo
            // 
            this.textCorreo.AutoSize = true;
            this.textCorreo.Enabled = false;
            this.textCorreo.Location = new System.Drawing.Point(151, 51);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(35, 13);
            this.textCorreo.TabIndex = 5;
            this.textCorreo.Text = "label2";
            this.textCorreo.Visible = false;
            // 
            // labbleCorreo
            // 
            this.labbleCorreo.AutoSize = true;
            this.labbleCorreo.Location = new System.Drawing.Point(51, 51);
            this.labbleCorreo.Name = "labbleCorreo";
            this.labbleCorreo.Size = new System.Drawing.Size(41, 13);
            this.labbleCorreo.TabIndex = 4;
            this.labbleCorreo.Text = "Correo:";
            this.labbleCorreo.Visible = false;
            // 
            // textTelefono
            // 
            this.textTelefono.AutoSize = true;
            this.textTelefono.Enabled = false;
            this.textTelefono.Location = new System.Drawing.Point(151, 74);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(35, 13);
            this.textTelefono.TabIndex = 7;
            this.textTelefono.Text = "label2";
            this.textTelefono.Visible = false;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(51, 74);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 6;
            this.labelTelefono.Text = "Telefono:";
            this.labelTelefono.Visible = false;
            // 
            // textEstadoCivil
            // 
            this.textEstadoCivil.AutoSize = true;
            this.textEstadoCivil.Enabled = false;
            this.textEstadoCivil.Location = new System.Drawing.Point(151, 96);
            this.textEstadoCivil.Name = "textEstadoCivil";
            this.textEstadoCivil.Size = new System.Drawing.Size(35, 13);
            this.textEstadoCivil.TabIndex = 9;
            this.textEstadoCivil.Text = "label2";
            this.textEstadoCivil.Visible = false;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(51, 96);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(65, 13);
            this.labelEstado.TabIndex = 8;
            this.labelEstado.Text = "Estado Civil:";
            this.labelEstado.Visible = false;
            // 
            // textHospital
            // 
            this.textHospital.AutoSize = true;
            this.textHospital.Enabled = false;
            this.textHospital.Location = new System.Drawing.Point(151, 119);
            this.textHospital.Name = "textHospital";
            this.textHospital.Size = new System.Drawing.Size(35, 13);
            this.textHospital.TabIndex = 13;
            this.textHospital.Text = "label2";
            this.textHospital.Visible = false;
            this.textHospital.Click += new System.EventHandler(this.textHospital_Click);
            // 
            // labelHospital
            // 
            this.labelHospital.AutoSize = true;
            this.labelHospital.Location = new System.Drawing.Point(51, 119);
            this.labelHospital.Name = "labelHospital";
            this.labelHospital.Size = new System.Drawing.Size(48, 13);
            this.labelHospital.TabIndex = 12;
            this.labelHospital.Text = "Hospital:";
            this.labelHospital.Visible = false;
            this.labelHospital.Click += new System.EventHandler(this.label11_Click);
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Card.Controls.Add(this.labelTelefono);
            this.Card.Controls.Add(this.textHospital);
            this.Card.Controls.Add(this.labbelName);
            this.Card.Controls.Add(this.labelHospital);
            this.Card.Controls.Add(this.textNombre);
            this.Card.Controls.Add(this.labbleCorreo);
            this.Card.Controls.Add(this.textCorreo);
            this.Card.Controls.Add(this.textEstadoCivil);
            this.Card.Controls.Add(this.textTelefono);
            this.Card.Controls.Add(this.labelEstado);
            this.Card.Location = new System.Drawing.Point(310, 61);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(246, 181);
            this.Card.TabIndex = 14;
            this.Card.Visible = false;
            this.Card.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.button2.Location = new System.Drawing.Point(-1, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VentanaConsultarInternacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(568, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaConsultarInternacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaConsultarInternacion";
            this.Load += new System.EventHandler(this.VentanaConsultarInternacion_Load);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labbelName;
        private System.Windows.Forms.Label textNombre;
        private System.Windows.Forms.Label textCorreo;
        private System.Windows.Forms.Label labbleCorreo;
        private System.Windows.Forms.Label textTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label textEstadoCivil;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label textHospital;
        private System.Windows.Forms.Label labelHospital;
        private System.Windows.Forms.Panel Card;
        private System.Windows.Forms.Button button2;
    }
}