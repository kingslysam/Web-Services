<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="client.aspx.cs" Inherits="SOAP.client" Trace="true" TraceMode="SortByTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <strong><u><p>Project Assignment</p></u></strong>
        <h4>Part 3 Qn2</h4>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Upper Bound:"></asp:Label>
            <asp:TextBox ID="upperBoundBox" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Lower Bound:"></asp:Label>
            <asp:TextBox ID="lowerBoundBox" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Amount of No:"></asp:Label>
            <asp:TextBox ID="amountNumber" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Produce random" Width="130px" />
        </div>
        <br />
        <div>
            <asp:Label ID="randomNumberLabel" runat="server"></asp:Label>
        </div>
        <br />
    </form>
</body>
</html>
