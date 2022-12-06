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

      

        private void ventanaConsultarCirugia_Load(object sender, EventArgs e)
        {
            SqlDataReader listaCirugias = conexionBD.traerInformacionDB("nombre","Cirugia",null,null);

            while (listaCirugias.Read())
            {
                combo_TipoCirugia.Items.Add(listaCirugias["nombre"]);
            }
        }
        private void combo_TipoCirugia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlDataReader consultaCirugiaNombrePaciente = conexionBD.traerInformacionDB("idPaciente", "Cirugia", "nombre", combo_TipoCirugia.Text);
            while (consultaCirugiaNombrePaciente.Read())
            {
                SqlDataReader pacientesConsulta = conexionBD.traerInformacionDB("*", "Paciente", "id", consultaCirugiaNombrePaciente["idPaciente"].ToString());
                while (pacientesConsulta.Read())
                {
                    txt_Nombre.Text=pacientesConsulta["nombre"]+" " + pacientesConsulta["apellido"];

                }
            }
            
        }

        private void combo_TipoCirugia_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Nombre.Text="";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ventanaConsulta consultas = new ventanaConsulta();
            consultas.Show();
            this.Visible = false;
        }
    }
}
