<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sessionEntry.aspx.cs" Inherits="sessionDictionary.sessionEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <strong><u><p>Project Assignment</p></u></strong>
        <h4>Part 2 Qn3</h4>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Time"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="timeBox" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="User Agent"></asp:Label>
            <asp:TextBox ID="userBox" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="RemoteIP"></asp:Label>
            &nbsp;
            <asp:TextBox ID="remoteBox" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />

        </div>
        <br />
    </form>
</body>
</html>
