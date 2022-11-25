using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHospitalesGrupoLos4.clases
{
    internal class Paciente
    {
        public int idHospital { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string estadoCivil { get; set; }
        public string patologia { get; set; }
        public bool activo { get; set; }
        public string tipo { get; set; }
        public Paciente() { }

        public Paciente(string nombre, string apellido, string telefono, string correo, string estadoCivil, string patologia, bool activo, int idHospital)
        {
            this.idHospital = idHospital;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.correo = correo;
            this.estadoCivil = estadoCivil;
            this.patologia = patologia;
            this.activo = activo;
        }
        public static int agregarPaciente(Paciente paciente)
        {
            int retorna = 0;

            using (SqlConnection conexion = conexionBD.abrirConexion())
            {
                string query = "insert into Paciente (nombre, apellido, telefono, correo, estadoCivil,activo, patologia, idHospital) values('" + paciente.nombre + "', '" + paciente.apellido + "', " + paciente.telefono + ", '" + paciente.correo + "', '" + paciente.estadoCivil + "', '" + paciente.activo + "' , '"+paciente.patologia+"', '"+paciente.idHospital+"')";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }
    }
}
