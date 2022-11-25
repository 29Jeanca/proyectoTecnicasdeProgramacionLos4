using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
namespace proyectoHospitalesGrupoLos4.clases
{
    public class Hospital
    {
        public string valorFiscal { get; set; }
        public string areaTerreno { get; set; }
        public string direccionExacta { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public string distrito { get; set; }
        public string cantidadNiveles { get; set; }
        public string cantidadConsultorios { get; set; }
        public string color { get; set; }
        public string tiposCirugia { get; set; }
        public string anioConstruccion { get; set; }


        public Hospital() { }

        public Hospital(string valorFiscal, string areaTerreno, string direccionExacta, string provincia, string canton, string distrito, string cantidadNiveles,string cantidadConsultorios ,string color, string tiposCirugia, string anioConstruccion)
        {
            this.valorFiscal = valorFiscal;
            this.areaTerreno = areaTerreno;
            this.direccionExacta = direccionExacta;
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.cantidadNiveles = cantidadNiveles;
            this.cantidadConsultorios = cantidadConsultorios;
            this.color = color;
            this.tiposCirugia = tiposCirugia;
            this.anioConstruccion = anioConstruccion;
        }
        public static int agregarHospital(Hospital hospital) {
            int retorna;

            SqlConnection conexion = conexionBD.abrirConexion();
            string cadenaBD = "INSERT INTO Hospital(valorFiscal,areaTerreno,direccionExacta,provincia,canton,distrito,cantidadNiveles,color,cantidadConsultorios,tiposCirugia,anioConstruccion) values('" + hospital.valorFiscal + "','" + hospital.areaTerreno + "','" + hospital.direccionExacta + "','" + hospital.provincia + "','" + hospital.canton + "','" + hospital.distrito + "','" + hospital.cantidadNiveles + "','"+hospital.color+"','"+hospital.cantidadConsultorios+"','" + hospital.tiposCirugia + "','" + hospital.anioConstruccion + "')";
            SqlCommand comando = new SqlCommand(cadenaBD, conexion);
            retorna = comando.ExecuteNonQuery();

            return  retorna;
        }

    }
}
