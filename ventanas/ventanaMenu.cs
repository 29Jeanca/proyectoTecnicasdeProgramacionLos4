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
            ventanaAgregarHospitales v_AgregarHospitales = new ventanaAgregarHospitales();
            v_AgregarHospitales.Show();
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
            ventanaAgregarDoctor ventanaDoctor = new ventanaAgregarDoctor();
            ventanaDoctor.Show();
            this.Visible = false;
        }
    }
}
