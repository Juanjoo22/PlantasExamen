using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PlantasExamen.CapaDatos;

namespace PlantasExamen.CapaLogica
{
    public class Plantas_Logica
    {
        private Cls_Plantas cls_Plantas = new Cls_Plantas();

        public DataTable ObtenerTodasPlantas()
        {
            return cls_Plantas.ListaPlantas();
        }

        public bool AgregarPlanta(string nombre, string nombreCientifico, string descripcion,
                                string requisitos, decimal precio, int stock, int categoriaID)
        {
            // Validaciones adicionales pueden ir aquí
            if (precio < 0)
                throw new ArgumentException("El precio no puede ser negativo");

            return cls_Plantas.InsertarPlanta(nombre, nombreCientifico, descripcion,
                                             requisitos, precio, stock, categoriaID);
        }

        public DataTable ObtenerReportePlantasPorCategoria()
        {
            try
            {
                DataTable reporte = cls_Plantas.ObtenerReportePlantasPorCategoria();

                return reporte;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al generar el reporte de plantas por categoría", ex);
            }
        }

    }   
}