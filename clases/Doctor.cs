using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHospitalesGrupoLos4.clases
{
    public class Doctor
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string especialidad { get; set; }
        public string gradoAcademico { get; set; }
        public string estadoCivil { get; set; }
        public int idHospital { get; set; }

        public Doctor() { }
        public Doctor(string nombre, string apellido, string telefono, string correo, string especialidad, string gradoAcademico, string estadoCivil, int idHospital)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.correo = correo;
            this.especialidad = especialidad;
            this.gradoAcademico = gradoAcademico;
            this.estadoCivil = estadoCivil;
            this.idHospital = idHospital;
        }
        public static int agregarDoctor(Doctor doctor)
        {
            using (SqlConnection conexion = conexionBD.abrirConexion())
            {
                string cadenaBD = "INSERT INTO Doctor (nombre, apellido, telefono,correo,especialidad,gradoAcademico,estadoCivil,idHospital) values('" + doctor.nombre + "', '" + doctor.apellido + "', '" + doctor.telefono + "', '" + doctor.correo + "','" + doctor.especialidad + "', '" + doctor.gradoAcademico + "','" + doctor.estadoCivil + "', '" + doctor.idHospital + "')";
                SqlCommand comando = new SqlCommand(cadenaBD, conexion);
                comando.ExecuteNonQuery();
            }
            return 1;
        }
    }
}
