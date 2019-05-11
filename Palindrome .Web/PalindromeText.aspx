<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PalindromeText.aspx.cs" Inherits="Palindrome.Web.PalindromeText" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            Palindrome Checker</div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Height="97px" OnClick="Button1_Click" Text="Test Palindrome" Width="416px" />
        <p>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
    </form>
</body>
</html>
