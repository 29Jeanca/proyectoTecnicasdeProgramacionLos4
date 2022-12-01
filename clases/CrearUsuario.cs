using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHospitalesGrupoLos4.clases
{
    public class CrearUsuario
    {
        public string usuario { get; set; }

        public string contrasenia { get; set; }
        public string tipoUsuario { get; set; }
    public CrearUsuario() { }
        
   
        public CrearUsuario(CrearUsuario inicioSesion)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.tipoUsuario = tipoUsuario;
        }
        public static int agregarInicioSesion(CrearUsuario inicioSesion)
        {
            int retorna;
            SqlConnection conexion = conexionBD.abrirConexion();
            string cadenaInsertar = "INSERT INTO InicioSesion (usuario,contrasenia,tipoUsuario)values('"+inicioSesion.usuario+"','"+inicioSesion.contrasenia+"','"+inicioSesion.tipoUsuario+"')";
            SqlCommand comando = new SqlCommand(cadenaInsertar, conexion);
            retorna = comando.ExecuteNonQuery();
            return retorna;
        }
    }

}
