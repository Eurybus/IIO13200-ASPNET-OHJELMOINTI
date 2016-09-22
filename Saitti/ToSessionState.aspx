<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ToSessionState.aspx.cs" Inherits="ToSessionState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Tapa 3: käytetään Session state:a</h1>
        <p>
            Sessionista luettu viesti: <%=Session["viesti"] %>
        </p>
    </div>
    </form>
</body>
</html>
