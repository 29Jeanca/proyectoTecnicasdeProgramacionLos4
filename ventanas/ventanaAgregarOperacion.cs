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
    public partial class ventanaAgregarOperacion : Form
    {
        public ventanaAgregarOperacion()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ventanaMenu v_Menu = new ventanaMenu();
            v_Menu.Show();
            this.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
            operacion.descripcion = txt_DescripcionOperacion.Text;
            operacion.fechaContrato = input_FechaContrato.Text;

            int contador = Operacion.agregarOperacion(operacion);
            if (contador > 0)
            {
                MessageBox.Show("Operación registrada con exito");
                txt_DescripcionOperacion.Text = "";
                txt_ValorContrato.Text = "";
            }
        }

        private void ventanaAgregarOperacion_Load(object sender, EventArgs e)
        {
            SqlDataReader IdHospitalLector = conexionBD.traerInformacionDB("id","Hospital",null,null);
            SqlDataReader IdPacienteLector = conexionBD.traerInformacionDB("id", "Paciente", null, null);
            SqlDataReader IdDoctorLector = conexionBD.traerInformacionDB("id", "Doctor", null, null);

            while (IdHospitalLector.Read())
            {
                combo_IdHospital.Items.Add(IdHospitalLector["id"].ToString());
            }
            while (IdPacienteLector.Read())
            {
                combo_IdHospital.Items.Add(IdPacienteLector["id"].ToString());
            }
            while (IdDoctorLector.Read())
            {
                combo_IdHospital.Items.Add(IdDoctorLector["id"].ToString());
            }
           
        }

        private void combo_IdDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_ValorContrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
