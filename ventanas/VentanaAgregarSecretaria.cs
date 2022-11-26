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
    public partial class VentanaAgregarSecretaria : Form
    {
        public VentanaAgregarSecretaria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Secretaria secretaria = new Secretaria();
            secretaria.nombre = txt_Nombre.Text;
            secretaria.apellido = txt_Apellido.Text;

            int contador = Secretaria.agregarSecretaria(secretaria);
            if (contador > 0)
            {
                MessageBox.Show("Nuevo registro agregado a secretaría");
                txt_Nombre.Text = "";
                txt_Apellido.Text = "";
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible= false;
        }
    }
}
