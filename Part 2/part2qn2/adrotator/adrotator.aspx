<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adrotator.aspx.cs" Inherits="adrotator.adrotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <strong><u><p>Project Assignment</p></u></strong>
        <h4>Part 2 Qn2</h4>
        <div>

            <asp:Label ID="Label2" runat="server" Text="Ads on varies companies"></asp:Label>

        </div>
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:Timer ID="Timer1" Interval="1" runat="server" />
            <asp:UpdatePanel ID="up1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
            <ContentTemplate>
                <asp:AdRotator ID="AdRotator1" AdvertisementFile="~/companies.xml" KeywordFilter="small"
                    runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
        </div>
        <br />
        <div>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next Ad" />

        </div>
        <br />
        <br />
    </form>
</body>
</html>
