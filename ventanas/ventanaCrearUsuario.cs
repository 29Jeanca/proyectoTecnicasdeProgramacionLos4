using proyectoHospitalesGrupoLos4.clases;
using proyectoHospitalesGrupoLos4.ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoHospitalesGrupoLos4
{
    public partial class ventanaCrearUsuario : Form
    {
        public ventanaCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.usuario = txt_Usuario.Text;
            crearUsuario.contrasenia = txt_Contrasenia.Text;
            crearUsuario.tipoUsuario = combo_TipoUsuario.Text;

            int contador = CrearUsuario.agregarInicioSesion(crearUsuario);
            if (contador > 0)
            {
                MessageBox.Show("Nuevo usuario registrado con exito");
                txt_Usuario.Text = "";
                txt_Contrasenia.Text = "";
                combo_TipoUsuario.SelectedIndex = -1;
                ventanaInicioSesion inicioSesion = new ventanaInicioSesion();
                inicioSesion.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Error al registrar al usuario");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }

        private void txt_Contrasenia_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            txt_Contrasenia.UseSystemPasswordChar = false;

        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            txt_Contrasenia.UseSystemPasswordChar = true;

        }
    }
    
}
