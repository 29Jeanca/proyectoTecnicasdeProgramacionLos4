using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace proyectoHospitalesGrupoLos4.clases
{
    public class Cirugia
    {
        public String nombre { get; set; }

        public Cirugia() { }

        public Cirugia(string nombre)
        {
            this.nombre = nombre;
        }
        public static int agregarCirugia(Cirugia cirugia)
        {
            int retorna;
            SqlConnection conexion = conexionBD.abrirConexion();
            {
                string cadenaBD = "INSERT into Cirugia (nombre) values('" + cirugia.nombre + "')";
                SqlCommand comando = new SqlCommand(cadenaBD, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }
    }
}
