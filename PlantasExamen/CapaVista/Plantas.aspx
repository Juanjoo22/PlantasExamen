<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Plantas.aspx.cs" Inherits="PlantasExamen.CapaVista.Plantas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lista de Plantas</h2>
    
    <asp:GridView ID="gvPlantas" runat="server" CssClass="table table-striped" 
        AutoGenerateColumns="False" OnRowCommand="gvPlantas_RowCommand">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="NombreCientifico" HeaderText="Nombre Científico" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" DataFormatString="{0:C}" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="btnEditar" runat="server" CommandName="Editar" 
                        CommandArgument='<%# Eval("PlantaID") %>' Text="Editar" CssClass="btn btn-primary" />
                    <asp:LinkButton ID="btnEliminar" runat="server" CommandName="Eliminar" 
                        CommandArgument='<%# Eval("PlantaID") %>' Text="Eliminar" CssClass="btn btn-danger" 
                        OnClientClick="return confirm('¿Está seguro de eliminar esta planta?');" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    
    <asp:Button ID="btnNuevaPlanta" runat="server" Text="Agregar Nueva Planta" 
        CssClass="btn btn-success" OnClick="btnNuevaPlanta_Click" />
</asp:Content>
