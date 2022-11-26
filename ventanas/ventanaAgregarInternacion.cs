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
    public partial class ventanaAgregarInternacion : Form
    {
        public ventanaAgregarInternacion()
        {
            InitializeComponent();
        }


        private void ventanaAgregarInternacion_Load(object sender, EventArgs e)
        {
            
            SqlDataReader hospitalRender = conexionBD.traerInformacionDB("id", "Hospital", null, null);
            while (hospitalRender.Read())
            {
                selectHospital.Items.Add(hospitalRender["id"]);
            }
            SqlDataReader pacienteRender = conexionBD.traerInformacionDB("nombre, id, apellido", "Paciente", "activo", "false");
            while (pacienteRender.Read())
            {
                selectPaciente.Items.Add(pacienteRender["id"] + " " +pacienteRender["nombre"] + " " + pacienteRender["apellido"]);
            }
            SqlDataReader doctorRender = conexionBD.traerInformacionDBDobleFiltro("nombre, id, apellido", "Doctor", "especialidad", "Medico general", "idHospital", selectHospital.Text);
            while (doctorRender.Read())
            {
                selectDoctor.Items.Add(doctorRender["id"] + " " + doctorRender["nombre"] + " " + doctorRender["apellido"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Internacion internacion = new Internacion();
            internacion.idHospital = Convert.ToInt32(selectHospital.Text);
            internacion.idPaciente = Convert.ToInt32(selectPaciente.Text.Split(' ')[0]);
            internacion.idDoctor = Convert.ToInt32(selectDoctor.Text.Split(' ')[0]);
            internacion.descripcion = txtDescripcion.Text;
            

            Contrato contrato = new Contrato();
            contrato.idHospital = Convert.ToInt32(selectHospital.Text);
            contrato.idPaciente = Convert.ToInt32(selectPaciente.Text.Split(' ')[0]);
            contrato.valorContrato = Convert.ToDouble(txtValorContrato.Text);
            contrato.fechaContrato = txtFechaContrato.Text;
            contrato.valorRestante = Convert.ToDouble(txtValorContrato.Text);
            contrato.codigoContrato = "INT" + conexionBD.generadorDeNumerosRandoms();
            contrato.nombre = selectPaciente.Text.Split(' ')[1];
            contrato.apellido = selectPaciente.Text.Split(' ')[2];
            if (selectHospital.Text != "" || selectDoctor.Text != "" || selectPaciente.Text != "" || txtValorContrato.Text != "")
            {
                Internacion.agregarInternacion(internacion);
                Contrato.agregarContrato(contrato);
                Paciente.cambiarPacienteActivo(contrato.idPaciente);
            }
            else {
                MessageBox.Show("faltan datos por digitar");
            }
            
        }

        private void selectDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }
    }
}
