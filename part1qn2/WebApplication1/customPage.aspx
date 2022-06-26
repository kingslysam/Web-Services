<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customPage.aspx.cs" Inherits="WebApplication1.WebForm1" Trace="true" TraceMode="SortByTime"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <div>
            
            <asp:Label ID="Label1" runat="server" Text="Index enter is out of range"></asp:Label>
            
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Try Again" />
        </div>
    </form>
</body>
</html>
