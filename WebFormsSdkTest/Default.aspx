<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsSdkTest.DefaultPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0 ,maximum-scale=1.0" />
</head>
<body>
    <form runat="server" role="form">
        <asp:ScriptManager runat="server"></asp:ScriptManager>

        <asp:UpdatePanel runat="server" ID="UpdatePanelMain">
            <ContentTemplate>
                Hello, world!
                <%= System.Net.SecurityProtocolType.Tls13.ToString() %>
                <%= int.TryParse("42", out var i) ? i : 0 %>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
