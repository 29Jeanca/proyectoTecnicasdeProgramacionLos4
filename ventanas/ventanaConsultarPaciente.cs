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
    public partial class ventanaConsultarPaciente : Form
    {
        public ventanaConsultarPaciente()
        {
            InitializeComponent();
        }

        private void ventanaConsultarPaciente_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txt_nombrePaciente.Visible = false;
            txt_estadoCivilPaciente.Visible = false;
            txt_patologia.Visible = false;
            SqlDataReader IdPacienteLector = conexionBD.traerInformacionDB("id,nombre,apellido", "Paciente",null,null);
            while (IdPacienteLector.Read())
            {
                combo_listaPacientes.Items.Add(IdPacienteLector["id"].ToString() + " " + IdPacienteLector["nombre"] + " " + IdPacienteLector["apellido"]);
            }
        }

        private void combo_listaPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            txt_nombrePaciente.Visible = true;
            txt_estadoCivilPaciente.Visible = true;
            txt_patologia.Visible = true;
            SqlDataReader seleccionarPacientes = conexionBD.traerInformacionDB("*", "Paciente", "id", combo_listaPacientes.Text.Split(' ')[0]);
            while (seleccionarPacientes.Read())
            {

                txt_nombrePaciente.Text = seleccionarPacientes["nombre"]+" " + seleccionarPacientes["apellido"];
                txt_estadoCivilPaciente.Text = seleccionarPacientes["estadoCivil"].ToString();
                txt_patologia.Text = seleccionarPacientes["patologia"].ToString();
            }
        }
    }
}
