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
    public partial class ventaAgregarPaciente : Form
    {
        public ventaAgregarPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ventaAgregarPaciente_Load(object sender, EventArgs e)
        {
            SqlDataReader hospitalRender = conexionBDJ.traerInformacionDB("id", "Hospital", null, null);
            while (hospitalRender.Read())
            {
                selectHospital.Items.Add(hospitalRender["id"]);
            }
            SqlDataReader patologiaRender = conexionBDJ.traerInformacionDB("nombre", "Patologia", null, null);
            while (patologiaRender.Read())
            {
                selectPatologia.Items.Add(patologiaRender["nombre"]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            
            paciente.nombre = txtNombre.Text;
            paciente.apellido = txtApellido.Text;
            paciente.telefono = txtTelefono.Text;
            paciente.correo = txtCorreo.Text;
            paciente.estadoCivil = selectEstadoCivil.Text;
            if (selectPatologia.Text == "")
            {
                paciente.patologia = txtOtraPatologia.Text;
                Patologia patologia = new Patologia();
                patologia.nombre = txtOtraPatologia.Text;
                Patologia.agregarPatologia(patologia);

            }
            else { paciente.patologia = selectPatologia.Text; }
            
            Paciente.agregarPaciente(paciente);
        }
    }
}
