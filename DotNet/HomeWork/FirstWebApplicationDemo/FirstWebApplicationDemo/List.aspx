<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="FirstWebApplicationDemo.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Width="268px"></asp:ListBox>
            
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
           
            &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
           
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Remove" Width="53px" />
            
        </div>
    </form>
</body>
</html>
