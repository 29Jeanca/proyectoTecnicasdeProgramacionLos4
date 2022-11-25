using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoHospitalesGrupoLos4.clases
{
    internal class Contrato
    {
        public int idPaciente { get; set; }
        public int idHospital { get; set; }
        public double valorContrato { get; set; }
        public string codigoContrato { get; set; }
        public double valorRestante { get; set; }
        public string fechaContrato { get; set; }

        public Contrato() { }
        public Contrato(int idPaciente, int idHospital, double valorContrato, string codigoContrato, double valorRestante, string fechaContrato)
        {
            this.idPaciente = idPaciente;
            this.idHospital= idHospital;
            this.valorContrato= valorContrato;
            this.codigoContrato= codigoContrato;
            this.valorRestante = valorRestante;
            this.fechaContrato= fechaContrato;
        }
        public static int agregarContrato(Contrato contrato)
        {
            using (SqlConnection conexion = conexionBD.abrirConexion())
            {
                string query = "insert into Contrato (idPaciente, idHospital, codigoCotrato, valorContrato, descripcion, valorRestante, fechaContrato) values('" + contrato.idPaciente + "', " + contrato.idHospital + ", '" + contrato.codigoContrato + "', " + contrato.valorContrato + ", " + contrato.valorRestante + ", '"+contrato.fechaContrato+"')";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
            return 1;
        }
    }
}
