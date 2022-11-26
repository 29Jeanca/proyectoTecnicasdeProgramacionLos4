using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHospitalesGrupoLos4.clases
{
    internal class Operacion
    {
        public int idPaciente { get; set; }
        public int idDoctor { get; set; }
        public int idHospital { get; set; }
        public string codigoContrato { get; set; }
        public double valorContrato { get; set; }
        public string descripcion { get; set; }
        public string fechaContrato { get; set; }

        public Operacion() { }
        public Operacion(int idPaciente, int idDoctor, int idHospital, string codigoContrato, double valorContrato, string descripcion, string fechaContrato)
        {
            this.idPaciente = idPaciente;
            this.idDoctor = idDoctor;
            this.idHospital = idHospital;
            this.codigoContrato = codigoContrato;
            this.valorContrato = valorContrato;
            this.descripcion = descripcion;
            this.fechaContrato = fechaContrato;
        }
        public static int agregarOperacion(Operacion operacion)
        {
            int retorna = 0;
            using (SqlConnection conexion = conexionBD.abrirConexion())
            {
                string cadenaInsertarBD = "INSERT INTO Operacion (idPaciente, idDoctor, idHospital, descripcion) values('" + operacion.idPaciente + "', '" + operacion.idDoctor + "', " + operacion.idHospital + ", '" + operacion.descripcion + "')";
                SqlCommand comando = new SqlCommand(cadenaInsertarBD, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }
    }
}
