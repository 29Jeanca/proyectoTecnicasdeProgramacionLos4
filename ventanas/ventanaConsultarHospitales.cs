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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectoHospitalesGrupoLos4.ventanas
{
    public partial class ventanaConsultarHospitales : Form
    {
        public ventanaConsultarHospitales()
        {
            InitializeComponent();
        }

        private void combo_IdHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader seleccionarHospitales = conexionBD.traerInformacionDB("*", "Hospital", "id", combo_IdHospital.Text.Split(' ')[0]);
            while (seleccionarHospitales.Read())
            {

                txt_valorFiscal.Text = seleccionarHospitales["valorFiscal"].ToString();
                txt_areaTerreno.Text = seleccionarHospitales["areaTerreno"].ToString();
                txt_direccionExacta.Text = seleccionarHospitales["direccionExacta"].ToString();
                txt_provincia.Text = seleccionarHospitales["provincia"].ToString();
                txt_canton.Text = seleccionarHospitales["canton"].ToString();
                txt_distrito.Text = seleccionarHospitales["distrito"].ToString();
                txt_cantidadNiveles.Text = seleccionarHospitales["cantidadNiveles"].ToString();
                txt_color.Text = seleccionarHospitales["color"].ToString();
                txt_cantidadConsultorios.Text = seleccionarHospitales["cantidadConsultorios"].ToString();
                txt_tiposCirugia.Text = seleccionarHospitales["tiposCirugia"].ToString();
                txt_anioConstruccion.Text = seleccionarHospitales["anioConstruccion"].ToString();
            }
                }

        private void ventanaConsultarHospitales_Load(object sender, EventArgs e)
        {
            
            SqlDataReader lectorHospitales = conexionBD.traerInformacionDB("id","Hospital",null,null);

            while (lectorHospitales.Read())
            {
                combo_IdHospital.Items.Add(lectorHospitales["id"]);
            }
        }

        private void txt_valorFiscal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            combo_IdHospital.SelectedIndex = -1;
            txt_valorFiscal.Text = " ";
            txt_areaTerreno.Text = " ";
            txt_direccionExacta.Text = " ";
            txt_provincia.Text = " ";
            txt_canton.Text = " ";
            txt_distrito.Text = " ";
            txt_cantidadNiveles.Text = " ";
            txt_color.Text = " ";
            txt_cantidadConsultorios.Text = " ";
            txt_tiposCirugia.Text = " ";
            txt_anioConstruccion.Text = " ";
        }
    }
}
