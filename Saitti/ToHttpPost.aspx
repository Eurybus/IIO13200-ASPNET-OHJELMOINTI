<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ToHttpPost.aspx.cs" Inherits="ToHttpPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Kohde 2: HttpPost -tapa</h1>
        <p>
            kutsuvalta sivulta luetaaan viesti:
            <%=Request.Form["txtMessage"] %>
        </p>
    </div>
    </form>
</body>
</html>
