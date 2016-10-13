<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RSSfeedit.aspx.cs" Inherits="RSSfeedit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnGetFeeds" runat="server" Text="Hae iltasanomat" OnClick="btnGetFeeds_Click" />
        <asp:Button ID="btnGetYleFeed" runat="server" Text="Hae Ylen uutiset" OnClick="btnGetYleFeed_Click" />
        <asp:Literal  ID="ltMessages" runat="server" />
        <asp:XmlDataSource ID="xdsFeedit" 
            XPath="rss/channel/item"
            runat="server"></asp:XmlDataSource>
        
    </div>
    </form>
</body>
</html>
