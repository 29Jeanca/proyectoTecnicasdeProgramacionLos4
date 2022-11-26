using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHospitalesGrupoLos4.clases
{
    public class Secretaria
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        public Secretaria() { }

        public Secretaria(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static int agregarSecretaria(Secretaria secretaria)
        {
            int retorna;

            SqlConnection conexion=conexionBD.abrirConexion();
            string cadenaBD= "INSERT INTO Secretaria (nombre) values('"+secretaria.nombre+"','"+secretaria.apellido+"')";
            SqlCommand comando = new SqlCommand(cadenaBD, conexion);
            retorna = comando.ExecuteNonQuery();

            return retorna;
        }
    }
}
