<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationButtonDemoApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="height:500px;width:500px">
        <asp:Button ID="Button1" runat="server" Height="35px" Text="Button" Width="122px" OnClick="Button1_Click" AutoPostBack ="true"/>
        <asp:TextBox ID="TextBox1" runat="server" Width="223px"></asp:TextBox>
    </form>
</body>
</html>
