using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlantasExamen.CapaLogica;

namespace PlantasExamen.CapaVista
{
	public partial class Plantas : System.Web.UI.Page
    {
        private Plantas_Logica plantas_Logica = new Plantas_Logica();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPlantas();
            }
        }

        private void CargarPlantas()
        {
            DataTable dtPlantas = plantas_Logica.ObtenerTodasPlantas();
            gvPlantas.DataSource = dtPlantas;
            gvPlantas.DataBind();
        }

        protected void btnNuevaPlanta_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevaPlanta.aspx");
        }

        protected void gvPlantas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Response.Redirect($"EditarPlanta.aspx?id={e.CommandArgument}");
            }
            else if (e.CommandName == "Eliminar")
            {
                int plantaID = Convert.ToInt32(e.CommandArgument);
                // Lógica para eliminar
                CargarPlantas(); // Refrescar la lista
            }
        }
    }
}