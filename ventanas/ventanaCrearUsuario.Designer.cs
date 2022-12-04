namespace proyectoHospitalesGrupoLos4
{
    partial class ventanaCrearUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaCrearUsuario));
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.combo_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(216, 231);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(159, 23);
            this.btnCrearUsuario.TabIndex = 12;
            this.btnCrearUsuario.Text = "Registrarse";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // combo_TipoUsuario
            // 
            this.combo_TipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_TipoUsuario.FormattingEnabled = true;
            this.combo_TipoUsuario.Items.AddRange(new object[] {
            "Doctor",
            "Secretaría"});
            this.combo_TipoUsuario.Location = new System.Drawing.Point(216, 181);
            this.combo_TipoUsuario.Name = "combo_TipoUsuario";
            this.combo_TipoUsuario.Size = new System.Drawing.Size(159, 21);
            this.combo_TipoUsuario.TabIndex = 11;
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.Location = new System.Drawing.Point(216, 114);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(159, 20);
            this.txt_Contrasenia.TabIndex = 10;
            this.txt_Contrasenia.UseSystemPasswordChar = true;
            this.txt_Contrasenia.TextChanged += new System.EventHandler(this.txt_Contrasenia_TextChanged);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(216, 53);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(159, 20);
            this.txt_Usuario.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(216, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(176)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 411);
            this.panel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(176)))), ((int)(((byte)(118)))));
            this.button2.Location = new System.Drawing.Point(4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo de Usuario";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(352, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 19);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave_1);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover_1);
            // 
            // ventanaCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(399, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.combo_TipoUsuario);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear un usuario";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.ComboBox combo_TipoUsuario;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

