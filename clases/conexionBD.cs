using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectoHospitalesGrupoLos4.clases
{
    public class conexionBD
    {
        public static SqlConnection abrirConexion()
        {
            string rutaJean = "Data Source=JEANCA;Initial Catalog=proyectoHospitales;Integrated Security=True";
            string rutaMiguel = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProjectTecnicas;Data Source=MIGUELA02";
            SqlConnection conexion = new SqlConnection(rutaJean);
            conexion.Open();
            return conexion;
        }
        public static SqlDataReader traerInformacionDB(string columnas, string tabla, string filtrar, string dato)
        {
            if (filtrar == null && dato == null)
            {
                SqlConnection conexion = abrirConexion();
                string query = "select " + columnas + " from " + tabla + ";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader renderPacientes = comando.ExecuteReader();
                return renderPacientes;
            }
            else
            {
                SqlConnection conexion = abrirConexion();
                string query = "select " + columnas + " from " + tabla + "  where " + filtrar + " = '" + dato + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader renderPacientes = comando.ExecuteReader();
                return renderPacientes;
            }

        }

        public static SqlDataReader traerInformacionDBDobleFiltro(string columnas, string tabla, string filtrar1, string dato1, string filtrar2, string dato2)
        {
            SqlConnection conexion = abrirConexion();
            string query = "select " + columnas + " from " + tabla + "  where " + filtrar1 + " = '" + dato1 + "' AND " + filtrar2 + "= '" + dato2 + "';";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader renderDoctores = comando.ExecuteReader();
            return renderDoctores;
        }
        public static SqlDataReader traerInformacionDBConComparacion()
        {
            SqlConnection conexion = abrirConexion();
            string query = "SELECT idPaciente, id , nombre, apellido, valorRestante FROM Contrato WHERE valorRestante > 0;" ;
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader renderContratos = comando.ExecuteReader();
            return renderContratos;
        }
        public static int generadorDeNumerosRandoms()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            return numero;
        }

    }

}
