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

            
        }

        private void ventanaAgregarOperacion_Load(object sender, EventArgs e)
        {
            SqlDataReader IdHospitalLector = conexionBD.traerInformacionDB("idHospital","-----",null,null);
            SqlDataReader IdPacienteLector = conexionBD.traerInformacionDB("idPaciente", "-----", null, null);
            SqlDataReader IdDoctorLector = conexionBD.traerInformacionDB("idDoctor", "--------", null, null);

            while (IdHospitalLector.Read())
            {
                combo_IdHospital.Items.Add(IdHospitalLector["idHospital"].ToString());
            }
            while (IdPacienteLector.Read())
            {
                combo_IdHospital.Items.Add(IdPacienteLector["idHospital"].ToString());
            }
            while (IdDoctorLector.Read())
            {
                combo_IdHospital.Items.Add(IdDoctorLector["idHospital"].ToString());
            }
        }

        private void combo_IdDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
