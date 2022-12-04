using proyectoHospitalesGrupoLos4.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoHospitalesGrupoLos4.ventanas
{
    public partial class ventanaAgregarHospitales : Form
    {
        public ventanaAgregarHospitales()
        {
            InitializeComponent();
        }

        private void ventanaAgregarHospitales_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarHospital_Click(object sender, EventArgs e)
        {
            Hospital hospital = new Hospital();
            hospital.valorFiscal = txt_ValorFiscal.Text;
            hospital.areaTerreno = txt_AreaTerreno.Text;
            hospital.direccionExacta = txt_DireccionExacta.Text;
            hospital.provincia = combo_Provincia.Text;
            hospital.canton = combo_Canton.Text;
            hospital.distrito = combo_Distrito.Text;
            hospital.cantidadNiveles = input_CantidadNiveles.Value.ToString();
            hospital.cantidadConsultorios = input_CantidadConsultorios.Value.ToString();
            hospital.color = txt_Color.Text;
            hospital.tiposCirugia = txt_TiposCirugia.Text;
            hospital.anioConstruccion = input_FechaConstruccion.Text;
            int contador = Hospital.agregarHospital(hospital);
            if (contador > 0)
            {
                MessageBox.Show("Hospital agregado con exito");
                txt_ValorFiscal.Text="";
                txt_AreaTerreno.Text = "";
                 txt_DireccionExacta.Text = "";
                combo_Provincia.SelectedIndex = -1;
                combo_Canton.SelectedIndex = -1;
                combo_Distrito.SelectedIndex = -1;
                 input_CantidadNiveles.Value=0;
                input_CantidadConsultorios.Value = 0;
                 txt_Color.Text = "";
                 txt_TiposCirugia.Text = "";
                input_FechaConstruccion.Text = "";
            }
            else
            {
                MessageBox.Show("No se pudo agregar el hospital");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }

        private void txt_Color_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txt_TiposCirugia_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_ValorFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }
    }
    }

