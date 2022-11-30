using proyectoHospitalesGrupoLos4.clases;
using System;
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
    public partial class ventanaConsultarCirugia : Form
    {
        public ventanaConsultarCirugia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ventanaConsultarCirugia_Load(object sender, EventArgs e)
        {
            SqlDataReader listaCirugias = conexionBD.traerInformacionDB("nombre","Cirugia",null,null);

            while (listaCirugias.Read())
            {
                combo_TipoCirugia.Items.Add(listaCirugias["nombre"]);
            }
        }

        private void combo_TipoCirugia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_TipoCirugia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlDataReader consultaCirugiaNombrePaciente = conexionBD.traerInformacionDB("idPaciente", "Cirugia", "nombre", combo_TipoCirugia.Text);
            SqlDataReader consultaCirugiaNombreDoctor = conexionBD.traerInformacionDB("idDoctor", "Cirugia", "nombre", combo_TipoCirugia.Text);
            SqlDataReader consultaCirugiaIdHospital = conexionBD.traerInformacionDB("idHospital", "Cirugia", null, combo_TipoCirugia.Text);
            while (consultaCirugiaNombrePaciente.Read())
            {
                SqlDataReader pacientesConsulta = conexionBD.traerInformacionDB("*", "Paciente", "id", consultaCirugiaNombrePaciente["idPaciente"].ToString());
                SqlDataReader doctorConsulta = conexionBD.traerInformacionDB("*", "Doctor", "id", consultaCirugiaNombreDoctor["idDoctor"].ToString());
                SqlDataReader hospitalConsulta = conexionBD.traerInformacionDB("*", "Hospital", "id", consultaCirugiaIdHospital["idHospital"].ToString());
                while (pacientesConsulta.Read())
                {
                    txt_Paciente.Text = pacientesConsulta["nombre"] + " " + pacientesConsulta["apellido"];
                    txt_Doctor.Text = (doctorConsulta["nombre"] + " " + doctorConsulta["apellido"]);
                    txt_IdHospital.Text = (hospitalConsulta["id"].ToString());
                }
            }
        }
    }
}
