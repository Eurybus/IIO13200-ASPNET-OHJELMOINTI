<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="IkkunaLaskuriProper.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #fieldWidth, #fieldHeight, #fieldFrameWidth {
            width: 48px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Leveys:  <asp:TextBox id="fieldWidth" runat="server"></asp:TextBox>mm<br />
        Kokeus: <asp:TextBox id="fieldHeight" runat="server"></asp:TextBox>mm<br />
        Karmipuun leveys(W): <asp:TextBox id="fieldFrameWidth" runat="server"></asp:TextBox>mm
        </p>
        <asp:Button runat="server" ID="btnSubmit" Text="Laske tarjoushinta" OnClick="btnSubmit_Click" />
        <p>
            Ikkunan Pinta-Ala: <asp:Label ID="lblArea" runat="server">N/A</asp:Label>m2<br />
            Karmin piiri: <asp:Label ID="lblPerimeter" runat="server">N/A</asp:Label>m<br />
            Tarjoushinta: <asp:Label ID="lblPrice" runat="server">N/A</asp:Label><br />
        </p>
    </div>
    </form>
</body>
</html>
