﻿using proyectoHospitalesGrupoLos4.clases;
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
    public partial class ventanaAgregarVisitasPost : Form
    {
        public ventanaAgregarVisitasPost()
        {
            InitializeComponent();
        }

        private void ventanaAgregarVisitasPost_Load(object sender, EventArgs e)
        {
            SqlDataReader idHospitalLector = conexionBD.traerInformacionDB("idHospital", "Operacion", null, null);
            SqlDataReader idPacienteLector = conexionBD.traerInformacionDB("idPaciente", "Operacion", null, null);
            SqlDataReader idDoctorLector = conexionBD.traerInformacionDB("idDoctor", "Operacion", null, null);
            while (idHospitalLector.Read()) {
                combo_IdHospital.Items.Add(idHospitalLector["idHospital"].ToString());
            }
            while (idPacienteLector.Read())
            {
                combo_IdPaciente.Items.Add(idPacienteLector["idPaciente"].ToString());
            }
            while (idDoctorLector.Read())
            {
                combo_IdDoctor.Items.Add(idDoctorLector["idDoctor"].ToString());
            }
        }

        private void btnAgregarVisitas_Click(object sender, EventArgs e)
        {
            
            Visitas_Post_Operatorias visitasPost = new Visitas_Post_Operatorias();
            visitasPost.idHospital = Convert.ToInt32(combo_IdHospital.Text);
            visitasPost.idPaciente = Convert.ToInt32(combo_IdPaciente.Text);
            visitasPost.idDoctor = Convert.ToInt32(combo_IdDoctor.Text);
            visitasPost.tipoVisita = combo_TipoChequeo.Text;
            visitasPost.estadoHerida = combo_EstadoHerida.Text;
            visitasPost.medicamento = txt_Medicamentos.Text;

            int contador = Visitas_Post_Operatorias.agregarVisitas(visitasPost);
            if (contador > 0)
            {
                MessageBox.Show("Visita almacenada con exito");
                combo_IdHospital.Text = " ";
                combo_IdPaciente.Text = " ";
                combo_IdDoctor.Text = " ";
                combo_TipoChequeo.Text = " ";
                combo_EstadoHerida.Text = " ";
                txt_Medicamentos.Text =" ";
            }
            else
            {
                MessageBox.Show("Error al guardar el dato");
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            ventanaMenu ventana_Menu = new ventanaMenu();
            ventana_Menu.Show();
            this.Visible = false;
        }
    }
}