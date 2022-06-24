<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nextPage.aspx.cs" Inherits="CookieWebApp.nextPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <strong><u><p>Project Assignment</p></u></strong>
        <h4>Part 2 Q1</h4>
        <div>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Remove Cookie" Width="120px" />
            &nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go Back" />

        </div>
        <br />
    </form>
</body>
</html>
