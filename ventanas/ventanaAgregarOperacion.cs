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
    public partial class ventanaAgregarOperacion : Form
    {
        public ventanaAgregarOperacion()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
            operacion.idHospital = Convert.ToInt32(combo_IdHospital.Text.Split('-')[0]);
            operacion.idPaciente = Convert.ToInt32(combo_IdPaciente.Text.Split('-')[0]);
            operacion.idDoctor = Convert.ToInt32(combo_IdDoctor.Text.Split('-')[0]);
            operacion.fechaContrato = input_FechaContrato.Text;
            if (combo_TipoCirugia.Text == "")
            {
                operacion.descripcion = txt_TipoCirugia.Text;
                Cirugia cirugia = new Cirugia();
                cirugia.nombre = txt_TipoCirugia.Text;
                Cirugia.agregarCirugia(cirugia);
            }
            else
            { 
                operacion.descripcion = combo_TipoCirugia.Text; 
            }
            Contrato contrato = new Contrato();
            contrato.idHospital = Convert.ToInt32(combo_IdHospital.Text);
            contrato.idPaciente = Convert.ToInt32(combo_IdPaciente.Text.Split('-')[0]);
            contrato.codigoContrato = "CIR" + conexionBD.generadorDeNumerosRandoms();



            int contador = Operacion.agregarOperacion(operacion);
            if (contador > 0)
            {
                MessageBox.Show("Operación registrada con exito");
                txt_ValorContrato.Text = "";
            }
        }

        private void ventanaAgregarOperacion_Load(object sender, EventArgs e)
        {
            SqlDataReader IdHospitalLector = conexionBD.traerInformacionDB("id", "Hospital", null, null);
            SqlDataReader IdPacienteLector = conexionBD.traerInformacionDB("id,nombre,apellido", "Paciente", null, null);
            SqlDataReader IdDoctorLector = conexionBD.traerInformacionDB("id,nombre,apellido", "Doctor", null, null);
            SqlDataReader idCirugiaLector = conexionBD.traerInformacionDB("nombre", null, null, null);
            while (IdHospitalLector.Read())
            {
                combo_IdHospital.Items.Add(IdHospitalLector["id"].ToString());
            }
            while (IdPacienteLector.Read())
            {
                combo_IdPaciente.Items.Add(IdPacienteLector["id"].ToString() + "-" + IdPacienteLector["nombre"] + " " + IdPacienteLector["apellido"]);
            }
            while (IdDoctorLector.Read())
            {
                combo_IdDoctor.Items.Add(IdDoctorLector["id"].ToString() + "-" + IdDoctorLector["nombre"] + " " + IdDoctorLector["apellido"]);
            }
            while (idCirugiaLector.Read())
            {
                combo_TipoCirugia.Items.Add(idCirugiaLector["nombre"].ToString());
            }
           
        }

        private void combo_IdDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
