<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ToQueryString.aspx.cs" Inherits="TiedonValitysTapa1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tapa 1: Query String</title>
</head>
<body>
    <form id="form1" runat="server">
    <!--Vaihtoehto 1: QueryString -->
    <div>
        <h1>Kohde 1: Query String -tapa</h1>
        <p>
            Sivulle Lähetettiin parametrinä viesti:
            <%=Request.QueryString["Data"] %>
        </p>
    </div>
    </form>
</body>
</html>
