using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHospitalesGrupoLos4.clases
{
    internal class Pago
    {
        public int idHospital { get; set; }
        public int idPaciente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string fechaDePago { get; set; }
        public double pagoTotal { get; set; }

        public Pago() { }
        public Pago(int idHospital, int idPaciente, string nombre,string apellido, string fechaDePago, double pago)
        {
            this.idHospital = idHospital;
            this.idPaciente = idPaciente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDePago = fechaDePago;
            this.pagoTotal = pago;
        }
        public static int agregarPago(Pago pago)
        {
            int retorna = 0;
            using (SqlConnection conexion = conexionBD.abrirConexion())
            {
                string query = "insert into Pago (idHospital, idPaciente, nombre, apellido, fechaDePago, pagoTotal) values('" + pago.idHospital + "', '" + pago.idPaciente + "', '" + pago.nombre + "', '" + pago.apellido + "', '" + pago.fechaDePago + "', '" + pago.pagoTotal+ "')";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }
    }
}
