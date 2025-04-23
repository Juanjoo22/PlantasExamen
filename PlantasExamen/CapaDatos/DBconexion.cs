using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PlantasExamen.CapaDatos
{
	public class DBconexion
    {
        private static string CadenaConexionPlantas = "Data Source=.;Initial Catalog=PlantasDB;Integrated Security=True";
        private static string CadenaConexionCategorias = "Data Source=.;Initial Catalog=CategoriasDB;Integrated Security=True";

        public static SqlConnection ObtenerConexionPlantas()
        {
            return new SqlConnection(CadenaConexionPlantas);
        }

        public static SqlConnection ObtenerConexionCategorias()
        {
            return new SqlConnection(CadenaConexionCategorias);
        }
    }
}