using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHospitalesGrupoLos4.clases
{
    public class Visitas_Post_Operatorias
    {
        public int idHospital { get; set; }
        public int idPaciente { get; set; }
        public int idDoctor { get; set; }
        public string tipoVisita { get; set; }
        public string estadoHerida { get; set; }
        public string gasto { get; set; }
        public string medicamento { get; set; }
        public string fechaVisita { get; set; }


        public Visitas_Post_Operatorias()
        {

        }       
        public Visitas_Post_Operatorias(int idHospital, int idPaciente, int idDoctor, string tipoVisita, string estadoHerida, string gasto, string medicamento, string fechaVisita)
        {
            this.idHospital = idHospital;
            this.idPaciente = idPaciente;
            this.idDoctor = idDoctor;
            this.tipoVisita = tipoVisita;
            this.estadoHerida = estadoHerida;
            this.gasto = gasto;
            this.medicamento = medicamento;
            this.fechaVisita = fechaVisita;
        }
        public static int agregarVisitas(Visitas_Post_Operatorias visitasOperatorias) {
            int retorna;
           
            SqlConnection conexion = conexionBD.abrirConexion();
            string cadenaBD = "INSERT INTO visitasPostOperatorias(idHospital,idPaciente,idDoctor,tipoVisita,estadoHerida,gasto,medicamento,fechaVisita) values(" + visitasOperatorias.idPaciente + "," + visitasOperatorias.idDoctor + "," + visitasOperatorias.idHospital + ",'" + visitasOperatorias.tipoVisita + "','" + visitasOperatorias.estadoHerida + "','" + visitasOperatorias.gasto + "','" + visitasOperatorias.gasto + "','" + visitasOperatorias.medicamento + "','" + visitasOperatorias.fechaVisita + "')";
            SqlCommand comando = new SqlCommand(cadenaBD, conexion);
            retorna=comando.ExecuteNonQuery();

            return retorna;
        }
    }
}
