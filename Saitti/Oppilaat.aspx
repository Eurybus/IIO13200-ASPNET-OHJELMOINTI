<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Oppilaat.aspx.cs" Inherits="Oppilaat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Oppilaat</h2>
        <div>
            <asp:Button ID="btnGet3" Text="Hae testioppilaat" OnClick="btnGet3_Click" runat="server"/>
            <asp:Button ID="btnGetReal" Text="Hae oikea data" OnClick   ="btnGetReal_Click" runat="server" />
        </div>
        <div id="tulos">
            <asp:GridView ID="gvStudents" runat="server" />
        </div>
        <div id="footer">
            <asp:Label ID="lblMessages" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
