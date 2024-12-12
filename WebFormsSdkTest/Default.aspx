<%@ page language="C#" autoeventwireup="true" codebehind="Default.aspx.cs" inherits="WebFormsSdkTest.DefaultPage" %>

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
            <contenttemplate>
                <ul>
                    <li>Hello, world!</li>
                    <li><%= System.Net.SecurityProtocolType.Tls13.ToString() %></li>
                    <li>TestClass1 from SomeX64Lib
                        <ul>
                            <li><%= tc.Architecture %></li>
                            <li><%= tc.Assembly %></li>
                        </ul>
                    </li>
                    <li>SiteClass from WebFormsSdkTest
                        <ul>
                            <li><%= sc.Architecture %></li>
                            <li><%= sc.Assembly %></li>
                        </ul>
                    </li>
                    <li>DefaultPage from WebFormsSdkTest
                        <ul>
                            <li><%= Architecture %></li>
                            <li><%= Assembly %></li>
                        </ul>
                    </li>
                    <li><%= int.TryParse("42", out var i) ? i : 0 %></li>
                    <li>OS is 64bit: <%= Environment.Is64BitOperatingSystem %></li>
                    <li>Process is 64 bit: <%= Environment.Is64BitProcess %></li>
                </ul>
            </contenttemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
