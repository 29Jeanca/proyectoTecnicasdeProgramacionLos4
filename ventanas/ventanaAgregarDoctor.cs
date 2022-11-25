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
    public partial class ventanaAgregarDoctor : Form
    {
        public ventanaAgregarDoctor()
        {
            InitializeComponent();
        }
        private void btnAgregarDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.nombre = txt_NombreDoctor.Text;
            doctor.apellido = txt_ApellidoDoctor.Text;
            doctor.telefono = txt_TelefonoDoctor.Text;
            doctor.correo = txt_CorreoDoctor.Text;
            doctor.especialidad = combo_EspecialidadDoctor.Text;
            doctor.gradoAcademico = combo_GradoAcademico.Text;
            doctor.estadoCivil = combo_EstadoCivil.Text;

            int contador = Doctor.agregarDoctor(doctor);

            if (contador > 0)
            {
                MessageBox.Show("Doctor guardado con exito");
                combo_IdHospital.Text = "";
                txt_NombreDoctor.Text = "";
                txt_ApellidoDoctor.Text = "";
                txt_TelefonoDoctor.Text = "";
                txt_CorreoDoctor.Text = "";
                combo_EspecialidadDoctor.Text = "";
                combo_GradoAcademico.Text = "";
                combo_EstadoCivil.Text = "";
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void ventanaAgregarDoctor_Load(object sender, EventArgs e)
        {
            SqlDataReader idHospitalLector = conexionBD.traerInformacionDB("id","Hospital",null,null);
            while (idHospitalLector.Read())
            {
                combo_IdHospital.Items.Add(idHospitalLector["id"].ToString());
            }
        }
    }
}
