<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sessionDisplay.aspx.cs" Inherits="sessionDictionary.sessionDispaly" Trace="true" TraceMode="SortByTime"%>

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
            <asp:Label Text="UserAgent:" runat="server"></asp:Label>
            <asp:Label ID="userLabel" runat="server"></asp:Label>

        </div>
        <br />
        <div>
            <asp:Label Text="RemoteIP:" runat="server"></asp:Label>
            <asp:Label ID="remoteLabel" runat="server"></asp:Label>

        </div>
        <br />
        <div>
            <asp:Label Text="Time on Creation:" runat="server"></asp:Label>
            <asp:Label ID="timeLabel" runat="server"></asp:Label>

        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go Back" />
        </div>
        <br />
    </form>
</body>
</html>
