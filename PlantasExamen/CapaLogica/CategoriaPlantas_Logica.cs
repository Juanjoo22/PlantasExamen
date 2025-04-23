using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PlantasExamen.CapaDatos;

namespace PlantasExamen.CapaLogica
{
	public class CategoriaPlantas_Logica
    {
        private Cls_Categorias cls_Categorias = new Cls_Categorias();

        public DataTable ObtenerTodasCategorias()
        {
            return cls_Categorias.ListaCategorias();
        }

        // Otros métodos de lógica para categorías...
    }
}