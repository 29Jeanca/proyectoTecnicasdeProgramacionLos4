namespace proyectoHospitalesGrupoLos4.ventanas
{
    partial class ventanaAgregarOperacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAgregarOperacion));
            this.combo_IdPaciente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_IdDoctor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_IdHospital = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DescripcionOperacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.input_FechaContrato = new System.Windows.Forms.DateTimePicker();
            this.txt_ValorContrato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_IdPaciente
            // 
            this.combo_IdPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdPaciente.FormattingEnabled = true;
            resources.ApplyResources(this.combo_IdPaciente, "combo_IdPaciente");
            this.combo_IdPaciente.Name = "combo_IdPaciente";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // combo_IdDoctor
            // 
            this.combo_IdDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdDoctor.FormattingEnabled = true;
            resources.ApplyResources(this.combo_IdDoctor, "combo_IdDoctor");
            this.combo_IdDoctor.Name = "combo_IdDoctor";
            this.combo_IdDoctor.SelectedIndexChanged += new System.EventHandler(this.combo_IdDoctor_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // combo_IdHospital
            // 
            this.combo_IdHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_IdHospital.FormattingEnabled = true;
            resources.ApplyResources(this.combo_IdHospital, "combo_IdHospital");
            this.combo_IdHospital.Name = "combo_IdHospital";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txt_DescripcionOperacion
            // 
            resources.ApplyResources(this.txt_DescripcionOperacion, "txt_DescripcionOperacion");
            this.txt_DescripcionOperacion.Name = "txt_DescripcionOperacion";
            // 
            // btnAgregar
            // 
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            resources.ApplyResources(this.btnAtras, "btnAtras");
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // input_FechaContrato
            // 
            resources.ApplyResources(this.input_FechaContrato, "input_FechaContrato");
            this.input_FechaContrato.Name = "input_FechaContrato";
            // 
            // txt_ValorContrato
            // 
            resources.ApplyResources(this.txt_ValorContrato, "txt_ValorContrato");
            this.txt_ValorContrato.Name = "txt_ValorContrato";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // ventanaAgregarOperacion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ValorContrato);
            this.Controls.Add(this.input_FechaContrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txt_DescripcionOperacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_IdHospital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_IdDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_IdPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaAgregarOperacion";
            this.Load += new System.EventHandler(this.ventanaAgregarOperacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_IdPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_IdDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_IdHospital;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DescripcionOperacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker input_FechaContrato;
        private System.Windows.Forms.TextBox txt_ValorContrato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}