<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tyontekijat.aspx.cs" Inherits="tyontekijat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tyontekijat</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnHae" runat="server" Text="Hae Työnekijät" OnClick="btnHae_Click" />
        <div id="esitys">
            <h2>Työntekijät</h2>
            <asp:GridView ID="gvData" runat="server"></asp:GridView>
        </div>
        <div id="footer">
            <asp:Label ID="lblMessages" runat="server" Text="---"></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
