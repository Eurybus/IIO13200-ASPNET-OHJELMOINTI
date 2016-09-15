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
    <!--<link href="http://www.w3schools.org/.css" rel="stylesheet" type="text/css" />-->
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    Leveys:
                </td>
                <td>
                     <asp:TextBox id="fieldWidth" runat="server"></asp:TextBox>mm
                </td>
            </tr>
            <tr>
                <td>
                    Korkeus:
                </td>
                <td>
                    <asp:TextBox id="fieldHeight" runat="server"></asp:TextBox>mm
                </td>
            </tr>
            <tr>
                <td>
                    Karmipuun leveys(W):
                </td>
                <td>
                    <asp:TextBox id="fieldFrameWidth" runat="server"></asp:TextBox>mm
                </td>
            </tr>
        </table>
        
        <asp:Button runat="server" ID="btnSubmit" Text="Laske tarjoushinta" OnClick="btnSubmit_Click" />
        <p>
            Ikkunan Pinta-Ala: <asp:Label ID="lblArea" runat="server">N/A</asp:Label>m2<br />
            Karmin piiri: <asp:Label ID="lblPerimeter" runat="server">N/A</asp:Label>m<br />
            Tarjoushinta: <asp:Label ID="lblPrice" runat="server">N/A</asp:Label>€<br />
        </p>
    </div>
        <div id="footer">
            <asp:Label ID="lblMessages" runat="server" />
        </div>
    </form>
</body>
</html>
