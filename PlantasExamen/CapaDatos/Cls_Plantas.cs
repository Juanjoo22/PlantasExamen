using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.Common;

namespace PlantasExamen.CapaDatos
{
    public class Cls_Plantas

    {
   
        public DataTable ListaPlantas()
        {
            using (SqlConnection conexion = DBconexion.ObtenerConexionPlantas())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarPlantas", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool InsertarPlanta(string nombre, string nombreCientifico, string descripcion,
                                  string requisitos, decimal precio, int stock, int categoriaID)
        {
            using (SqlConnection conexion = DBconexion.ObtenerConexionPlantas())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarPlanta", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@NombreCientifico", nombreCientifico);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@RequisitosCuidado", requisitos);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);

                conexion.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public DataTable ObtenerReportePlantasPorCategoria()
        {
            using (SqlConnection conexion = DBconexion.ObtenerConexionPlantas())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerReportePlantasPorCategoria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}