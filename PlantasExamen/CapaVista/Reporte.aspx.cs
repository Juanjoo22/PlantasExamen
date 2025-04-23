using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using PlantasExamen.CapaLogica;

namespace PlantasExamen.CapaVista
{
    public partial class Reporte : System.Web.UI.Page
    {
        private Plantas_Logica plantas_Logica = new Plantas_Logica();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarReporte();
            }
        }

        private void CargarReporte()
        {
            try
            {
                DataTable dtReporte = plantas_Logica.ObtenerReportePlantasPorCategoria();

                // Configurar gráfico
                chartPlantasPorCategoria.Series[0].Points.DataBind(dtReporte.DefaultView, "NombreCategoria", "Cantidad", "");
                chartPlantasPorCategoria.Series[0].ChartType = SeriesChartType.Column;
                chartPlantasPorCategoria.ChartAreas[0].AxisX.Title = "Categoría";
                chartPlantasPorCategoria.ChartAreas[0].AxisY.Title = "Cantidad de Plantas";
                chartPlantasPorCategoria.Series[0].Label = "#VALY"; // Mostrar valores en las columnas

                // Configurar grid
                gvReporte.DataSource = dtReporte;
                gvReporte.DataBind();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error al usuario
                lblMensaje.Text = "Error al cargar el reporte: " + ex.Message;
                lblMensaje.CssClass = "alert alert-danger";
            }
        }
    }
}