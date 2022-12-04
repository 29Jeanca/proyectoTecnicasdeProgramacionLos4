using proyectoHospitalesGrupoLos4.clases;
using System;
using System.Collections;
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
    public partial class ventanaInicioSesion : Form
    {
        public ventanaInicioSesion()
        {
            InitializeComponent();
        }
  
        private void ventanaInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

           
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ventanaCrearUsuario crearUsuario = new ventanaCrearUsuario();
            crearUsuario.Show();
            this.Visible = false;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conexionBD.abrirConexion();
            string verificarBD = "SELECT usuario,contrasenia,tipoUsuario FROM InicioSesion WHERE usuario = @vusuario AND contrasenia = @vcontrasenia AND tipoUsuario=@vtipoUsuario";
            SqlCommand comando = new SqlCommand(verificarBD, conexion);
            comando.Parameters.AddWithValue("@vusuario", txt_Usuario.Text);
            comando.Parameters.AddWithValue("@vcontrasenia", txt_Contrasenia.Text);
            comando.Parameters.AddWithValue("@vtipoUsuario", combo_TipoUsuario.Text);

            SqlDataReader lector = comando.ExecuteReader();
            string tipoUsuario = combo_TipoUsuario.Text;
            if (tipoUsuario == "Secretaría")
            {
                ventanaConsulta consulta = new ventanaConsulta();
                consulta.Show();
                this.Visible = false;
            }
            else if (tipoUsuario == "Doctor")
            {
                ventanaMenu menu = new ventanaMenu();
                menu.Show();
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("Nombre de usuario,contraseña y/o tipo de usuario incorrectos");
                txt_Usuario.Text = "";
                txt_Contrasenia.Text = "";
                combo_TipoUsuario.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            txt_Contrasenia.UseSystemPasswordChar = false;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            txt_Contrasenia.UseSystemPasswordChar = true;
        }
    }
    }

