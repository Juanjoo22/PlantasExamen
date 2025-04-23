<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="PlantasExamen.CapaVista.Reporte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Reporte: Plantas por Categoría</h2>
<asp:Label ID="lblMensaje" runat="server" CssClass="alert"></asp:Label>
    
    <asp: ID="chartPlantasPorCategoria" runat="server" Width="600px">
        <Series>
            <asp: Name="Series1" ChartType="Column"></asp:>
        </Series>
        <ChartAreas>
            <asp: Name="ChartArea1"></asp:>
        </ChartAreas>
    </asp:>
    
    <asp:GridView ID="gvReporte" runat="server" CssClass="table table-striped">
    </asp:GridView>
</asp:Content>
