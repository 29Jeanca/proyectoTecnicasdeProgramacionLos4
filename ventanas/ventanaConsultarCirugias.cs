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
    public partial class ventanaConsultarCirugias : Form
    {
        public ventanaConsultarCirugias()
        {
            InitializeComponent();
        }

        private void ventanaConsultarCirugias_Load(object sender, EventArgs e)
        {
            SqlDataReader cirugiasLector = conexionBD.traerInformacionDB("nombre", "Cirugia", null, null);
            while (cirugiasLector.Read())
            {
                combo_ConsultarCirugias.Items.Add(cirugiasLector["nombre"].ToString());
            }
        }

        private void combo_ConsultarCirugias_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader consultaCirugia = conexionBD.traerInformacionDB("idPaciente", "Cirugia", "nombre", combo_ConsultarCirugias.Text);
            while (consultaCirugia.Read())
            {
                SqlDataReader pacientesConsulta = conexionBD.traerInformacionDB("*", "Paciente", "id", consultaCirugia["idPaciente"].ToString());

                while (pacientesConsulta.Read())
                {
                    prueba.Text = (pacientesConsulta["nombre"] + " " + pacientesConsulta["apellido"] + " ");
                }
            }
        }
    }
}
