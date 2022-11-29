using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoHospitalesGrupoLos4.ventanas
{
    public partial class ventanaMenu : Form
    {
        public ventanaMenu()
        {
            InitializeComponent();
        }

        private void btnAgregarDoctor_Click(object sender, EventArgs e)
        {
            ventanaAgregarDoctor ventanaDoctor = new ventanaAgregarDoctor();
            ventanaDoctor.Show();
            this.Visible = false;
        }

        private void btnAgregarVisita_Click(object sender, EventArgs e)
        {
            ventanaAgregarVisitasPost v_VisitasPost = new ventanaAgregarVisitasPost();
            v_VisitasPost.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaAgregarPaciente ventanaPaciente = new ventanaAgregarPaciente();
            ventanaPaciente.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaAgregarInternacion ventanaInternacion = new ventanaAgregarInternacion(); 
            ventanaInternacion.Show();
            this.Visible = false;
        }

        private void ventanaMenu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ventanaAgregarHospitales ventanaHospital = new ventanaAgregarHospitales();
            ventanaHospital.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ventanaAgregarPago ventanaPago = new ventanaAgregarPago();
            ventanaPago.Show(); 
            this.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarSecretaria_Click(object sender, EventArgs e)
        {
            VentanaAgregarSecretaria ventanaSecretaria = new VentanaAgregarSecretaria();
            ventanaSecretaria.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ventanaAgregarOperacion ventanaOperacion = new ventanaAgregarOperacion();
            ventanaOperacion.Show();
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ventanaConsulta consultas = new ventanaConsulta();
            consultas.Show();
            this.Visible = false;
        }
    }
}
