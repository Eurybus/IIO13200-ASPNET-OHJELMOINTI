<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SourcePage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tideon välitys demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Source -sivu</h1>
        <p>
            Lähetä viesti: <asp:TextBox ID="txtMessage" runat="server" />
            <!--Tähän lista, josta voi valita valmiin lauseen-->
            <asp:DropDownList ID="ddlMessages" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:Button ID="btnQueryString" runat="server" Text="Käytä QueryString"
                onclick="btnQueryString_Click" /><br />
        
        <!-- Vaihtoehto 2: HttpPost-->
        <asp:Button ID="btnHttpPost" runat="server" Text="Käytä HttpPost" PostBackUrl="~/ToHttpPost.aspx" /><br />
        <!-- Vaihtoehto 3: SessionState-->
        <asp:Button ID="BtnSession" runat="server" Text="Käytä Session state:a" onclick="BtnSession_Click"  /><br />
        <!-- Vaihtoehto 4: Cookie-->
        <asp:Button ID="btnCookie" runat="server" Text="Käytä Session cookieta" onclick="btnCookie_Click"  /><br />
        <!-- Vaihtoehto 5: public property-->
        <asp:Button ID="btnProperty" runat="server" Text="Käytä ominaisuutta (Public property)" onclick="btnProperty_Click"  /><br />
            </p>
    </div>
    </form>
</body>
</html>
