<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="removeCookie.aspx.cs" Inherits="removeCookies.removeCookie" Trace="true" TraceMode="SortByTime"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <strong><u><p>Project Assignment</p></u></strong>
        <h4>Part 2 Qn5</h4>
        <div>
            <asp:Label ID="cookiePresence" runat="server"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label Text="Current Cookie:" runat="server"></asp:Label>
            <asp:Label ID="cookieLabel" runat="server"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Button ID="removeButton" runat="server" Text="Remove cookie" Width="150px" OnClick="removeButton_Click" />
        </div>
        <br />
    </form>
</body>
</html>
