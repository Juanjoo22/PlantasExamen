<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="PlantasExamen.CapaVista.Principal" %>


<!DOCTYPE html>
<html lang="es">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Catálogo de Plantas</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <nav class="navbar navbar-expand-md navbar-dark bg-success">
                <div class="container">
                    <a class="navbar-brand" href="~/">Catálogo de Plantas</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarCollapse">
                        <ul class="navbar-nav me-auto">
                            <li><a  href="Plantas.aspx">Plantas</a></li>
                            <li><a  href="Reporte.aspx">Reportes</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
        </header>

        <main class="container my-4">
            <asp id="MainContent" runat="server">
            </asp>
        </main>

        <footer class="border-top footer text-muted">
        </footer>
    </form>


    <div class="container">
        &copy; <%: DateTime.Now.Year %> - Catálogo de Plantas
    </div>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js"></script>

</body>
</html>
