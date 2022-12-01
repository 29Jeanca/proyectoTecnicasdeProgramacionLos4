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
    public partial class ventanaAgregarPaciente : Form
    {
        public ventanaAgregarPaciente()
        {
            InitializeComponent();
        }

        private void ventanaAgregarPaciente_Load(object sender, EventArgs e)
        {
            SqlDataReader hospitalRender = conexionBD.traerInformacionDB("id", "Hospital", null, null);
            while (hospitalRender.Read())
            {
                selectHospital.Items.Add(hospitalRender["id"]);
            }
            SqlDataReader patologiaRender = conexionBD.traerInformacionDB("nombre", "Patologia", null, null);
            while (patologiaRender.Read())
            {
                selectPatologia.Items.Add(patologiaRender["nombre"]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.nombre = txtNombre.Text;
            paciente.apellido = txtApellido.Text;
            paciente.telefono = txtTelefono.Text;
            paciente.idHospital = Convert.ToInt32(selectHospital.Text);
            paciente.correo = txtCorreo.Text;
            paciente.estadoCivil = selectEstadoCivil.Text;
            if (selectPatologia.Text == "")
            {
                paciente.patologia = txtOtraPatologia.Text;
                Patologia patologia = new Patologia();
                patologia.nombre = txtOtraPatologia.Text;
                Patologia.agregarPatologia(patologia);
            }
            else { paciente.patologia = selectPatologia.Text;
                Patologia patologia = new Patologia();
                patologia.nombre = selectPatologia.Text;
                Patologia.agregarPatologia(patologia);
            }

            int contador=Paciente.agregarPaciente(paciente);

            if (contador > 0)
            {
                MessageBox.Show("Exito al registrar al paciente");
                txtNombre.Text="";
                txtApellido.Text="";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                selectHospital.SelectedIndex = -1;
                selectEstadoCivil.SelectedIndex=-1;
                selectPatologia.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Error al registrar al paciente");
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void selectPatologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectPatologia.SelectedIndex>=0)
            {
                txtOtraPatologia.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectPatologia.SelectedIndex = -1;
            txtOtraPatologia.Enabled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtOtraPatologia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ventanaMenu menu=new ventanaMenu();
            menu.Show();
            this.Visible = false;
        }
    }
}
