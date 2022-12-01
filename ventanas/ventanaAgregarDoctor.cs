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
            doctor.idHospital = Convert.ToInt32(combo_IdHospital.Text);
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
                combo_IdHospital.SelectedIndex = -1;
                txt_NombreDoctor.Text = "";
                txt_ApellidoDoctor.Text = "";
                txt_TelefonoDoctor.Text = "";
                txt_CorreoDoctor.Text = "";
                combo_EspecialidadDoctor.SelectedIndex=-1;
                combo_GradoAcademico.SelectedIndex = -1;
                combo_EstadoCivil.SelectedIndex = -1;
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }

        private void txt_TelefonoDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NombreDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NombreDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_ApellidoDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void txt_TelefonoDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
           
        }
    }
}
