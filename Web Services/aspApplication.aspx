<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aspApplication.aspx.cs" Inherits="Web_Services.aspApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <strong><u><p>Project Assignment</p></u></strong>
        <h4>Part 1 Q1</h4>
        <div style="height: 57px">
            <asp:Label ID="namelabel" runat="server" Text="Name:">&nbsp;&nbsp;Name:</asp:Label>
            <br />
            <asp:TextBox ID="namebox" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
        </div>
        <div style="height: 58px">

            <asp:Label ID="Label1" runat="server" Text="Favourite technology:"></asp:Label><br />

            <asp:DropDownList ID="techlist" runat="server">
                <asp:ListItem>Select a technology</asp:ListItem>
                <asp:ListItem>ASP.Net</asp:ListItem>
                <asp:ListItem>ADO.Net</asp:ListItem>
                <asp:ListItem>C#</asp:ListItem>
            </asp:DropDownList>

        </div>
        <div style="height: 63px">
            <asp:Label ID="Label2" runat="server" Text="Comment"></asp:Label><br />
            <textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea><br/>
        </div>
        <div>
            <br/>
            <asp:Button ID="Clicksubmit" runat="server" Text="Submit" OnClick="Clicksubmit_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px"/>

        </div>
        <br />
        <div style="height: 30px">
            <asp:Label ID="empty" runat="server"></asp:Label>
            <br/>

        </div>
    </form>
</body>
</html>
