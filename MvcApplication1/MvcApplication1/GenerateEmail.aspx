<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateEmail.aspx.cs" Inherits="MvcApplication1.GenerateEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Generate E-Mail</title>
</head>
<body style="width: 337px; height: 220px;">
    <form id="form1" runat="server">
    <div>
    
        <br />
        Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtRecipientName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="E Mail ID : "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtRecipientEmail" runat="server"></asp:TextBox>
        <br />
        <br />
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate Email" Width="145px" />
        <br />
    
     </div>
    </form>
</body>
</html>
