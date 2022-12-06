using proyectoHospitalesGrupoLos4.clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoHospitalesGrupoLos4.ventanas
{
    public partial class VentanaConsultarInternacion : Form
    {
        public VentanaConsultarInternacion()
        {
            InitializeComponent();
        }

        private void VentanaConsultarInternacion_Load(object sender, EventArgs e)
        {
            SqlDataReader internaciones = conexionBD.traerInformacionDB("idPaciente", "Internacion", null, null);
            
            while (internaciones.Read())
            {
                SqlDataReader pacientes = conexionBD.traerInformacionDB("*", "Paciente", "id", internaciones["idPaciente"].ToString());
                while (pacientes.Read())
                {
                    comboBox1.Items.Add(pacientes["id"] + " " + pacientes["nombre"] + " " + pacientes["apellido"]);
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader pacienteSelect = conexionBD.traerInformacionDB("*", "Paciente", "id", comboBox1.Text.Split(' ')[0]);
            while (pacienteSelect.Read())
            {
                textNombre.Text = pacienteSelect["nombre"] + " " + pacienteSelect["apellido"];
                textNombre.Visible = true;
                textCorreo.Text = pacienteSelect["correo"].ToString();
                textCorreo.Visible = true;
                textTelefono.Text = pacienteSelect["telefono"].ToString();
                textTelefono.Visible = true;
                textEstadoCivil.Text = pacienteSelect["estadoCivil"].ToString();
                textEstadoCivil.Visible = true;
                textHospital.Text = pacienteSelect["idHospital"].ToString();
                Card.Visible = true;
                textHospital.Visible = true;
                labbelName.Visible = true;
                labbleCorreo.Visible = true;
                labelTelefono.Visible = true;
                labelHospital.Visible = true;
                labelEstado.Visible = true;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textHospital_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ventanaConsulta consulta = new ventanaConsulta();
            consulta.Show();
            this.Visible = false;
        }
    }
}
