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
            SqlDataReader pacienteRender = conexionBD.traerInformacionDB("nombre, id", "Paciente", "activo", "false");
            while (pacienteRender.Read())
            {
                selectPaciente.Items.Add(pacienteRender["id"] + "-" +pacienteRender["nombre"]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Internacion internacion = new Internacion();
            internacion.idHospital = Convert.ToInt32(selectHospital.Text);
            internacion.idPaciente = Convert.ToInt32(selectPaciente.Text);
            internacion.idDoctor = Convert.ToInt32(selectDoctor.Text);
            internacion.descripcion = txtDescripcion.Text;

            Contrato contrato = new Contrato();
            contrato.idHospital = Convert.ToInt32(selectHospital.Text);
            contrato.idPaciente = Convert.ToInt32(selectPaciente.Text);
            contrato.valorContrato = Convert.ToDouble(txtValorContrato.Text);
            contrato.fechaContrato = txtFechaContrato.Text;
            contrato.valorRestante = Convert.ToDouble(txtValorContrato.Text);
        }

        private void selectDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader doctorRender = conexionBD.traerInformacionDBDobleFiltro("nombre, id", "Doctor", "especialidad", "Medico general", "idHospital", selectHospital.Text);
            while (doctorRender.Read())
            {
                selectDoctor.Items.Add(doctorRender["id"] + "-" + doctorRender["nombre"]);
            }
        }
    }
}
