using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHospitalesGrupoLos4.clases
{
    internal class Internacion
    {
        public int idHospital { get; set; }
        public int idPaciente { get; set; }
        public int idDoctor { get; set; }
        public string descripcion { get; set; }

        public Internacion() { }
        public Internacion(int idHospital, int idPaciente, int idDoctor, string descripcion)
        {
            this.idHospital = idHospital;
            this.idPaciente = idPaciente;
            this.idDoctor = idDoctor;
            this.descripcion = descripcion;
        }

        public static int agregarInternacion(Internacion internacion)
        {
            int retorna = 0;

            using (SqlConnection conexion = conexionBD.abrirConexion())
            {
                string query = "insert into Internacion (idPaciente, idHospital, idDoctor, descripcion) values("+internacion.idPaciente+", "+internacion.idHospital+", "+internacion.idDoctor+", "+internacion.descripcion+")";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }
    }
}
