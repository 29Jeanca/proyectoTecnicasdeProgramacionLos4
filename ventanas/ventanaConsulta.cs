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
    public partial class ventanaConsulta : Form
    {
        public ventanaConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaConsultarInternacion consultaInternacion = new VentanaConsultarInternacion();
            consultaInternacion.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaConsultarCirugia consultarCirugia = new ventanaConsultarCirugia();
            consultarCirugia.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ventanaInicioSesion inicio = new ventanaInicioSesion();
            inicio.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ventanaConsultarHospitales consultarHospitales = new ventanaConsultarHospitales();
            consultarHospitales.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ventanaConsultarPaciente consultarPaciente = new ventanaConsultarPaciente();
            consultarPaciente.Show();
            this.Visible = false;
        }
    }
}
