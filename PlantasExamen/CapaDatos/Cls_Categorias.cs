using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace PlantasExamen.CapaDatos
{
	public class Cls_Categorias
	{
        public DataTable ListaCategorias()
        {
            using (SqlConnection conexion = DBconexion.ObtenerConexionCategorias())
            {
                SqlCommand cmd = new SqlCommand("sp_ListaCategorias", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}