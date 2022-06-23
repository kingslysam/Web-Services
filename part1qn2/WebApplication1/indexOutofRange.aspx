<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexOutofRange.aspx.cs" Inherits="WebApplication1.indexOutofRange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <u><strong><h3>Project Assignment</h3></strong></u>
        <u><p>Part 1 Qn2</p></u>
        <div style="height: 86px">
            <asp:Label ID="Label1" runat="server" Text="Enter number:"></asp:Label>
            &nbsp;<asp:TextBox ID="enternum" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Enter Index:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="enterIndex" runat="server"></asp:TextBox>

        </div>
        <div style="height: 57px">
           
            <asp:Button ID="Button1" runat="server" Text="Add number" OnClick="Button1_Click" />
            &nbsp;&nbsp;</div>
        <asp:Label ID="checklabeled" runat="server"></asp:Label>
        <br /><br />
    </form>
</body>
</html>
