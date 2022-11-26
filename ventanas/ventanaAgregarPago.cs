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
    public partial class ventanaAgregarPago : Form
    {
        public ventanaAgregarPago()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ventanaAgregarPago_Load(object sender, EventArgs e)
        {
            ArrayList arrayList= new ArrayList();
            SqlDataReader hospitalRender = conexionBD.traerInformacionDB("id", "Hospital", null, null);
            while (hospitalRender.Read())
            {
                selectHospital.Items.Add(hospitalRender["id"]);
            }
            SqlDataReader contratoRender = conexionBD.traerInformacionDBConComparacion();
            while (contratoRender.Read()) 
            {
                selectPaciente.Items.Add(contratoRender["id"] + " " +  contratoRender["nombre"] + " " + contratoRender["apellido"] + "-" + contratoRender["valorRestante"] );
                arrayList.Add(contratoRender["idPaciente"] + " " + contratoRender["id"] + " " + contratoRender["valorRestante"]);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            Pago pago = new Pago();
            pago.idHospital = Convert.ToInt32(selectHospital.Text);
            pago.idPaciente = Convert.ToInt32(selectPaciente.Text.Split(' ')[0]);
            pago.nombre = txtNombre.Text;
            pago.apellido = txtNombre.Text;
            pago.pagoTotal = Convert.ToDouble(txtPago.Text);
            pago.fechaDePago = thisDay.ToString("D");
            double valorRestante = Convert.ToDouble(selectPaciente.Text.Split('-')[1]);
            double pagoActual = Convert.ToDouble(txtPago.Text);
            if (Contrato.restarPagoRestante(pago.idPaciente, valorRestante, pagoActual))
            {
                Pago.agregarPago(pago);
                
            }
            else {
                MessageBox.Show("El monto a pagar es " + valorRestante + ", por favor digite un monto valido");
            }
            
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
