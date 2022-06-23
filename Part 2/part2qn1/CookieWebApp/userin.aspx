<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userin.aspx.cs" Inherits="CookieWebApp.userin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <strong><u><p>Project Assignment</p></u></strong>
        <h4>Part 2 Qn1</h4>
        <div>

            <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="uname" runat="server"></asp:TextBox>

        </div>
        <div>
            <br />
            <asp:Button ID="enterButton" runat="server" Text="Enter" OnClick="enterButton_Click" />
            &nbsp;&nbsp;
            &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="View Current Cookie" OnClick="Button1_Click" Width="160px" />

        </div>
        <br />
    </form>
</body>
</html>
