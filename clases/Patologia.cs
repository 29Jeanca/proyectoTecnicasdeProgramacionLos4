using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHospitalesGrupoLos4.clases
{
    public class Patologia
    {
        public string nombre { get; set; }

        public Patologia() { }
        public Patologia(string nombre) 
        {
            this.nombre = nombre;
        }
        public static int agregarPatologia(Patologia patologia)
        {
            int retorna = 0;
            using (SqlConnection conexion = conexionBD.abrirConexion())
            {
                string query = "insert into Patologia (nombre) values('"+patologia.nombre+"')";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }
    }
}
