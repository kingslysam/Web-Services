<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stockprice.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server" align="center">
       <u><strong><h3>Project Assignment</h3></strong></u>
       <u><p>Part 1 Qn3</p></u>
         <div>          
             Enter one to view stock price.
             <br />
             1.RELIND<br />
             2.ICICI<br />
             3.JSW<br />
             4.WIPRO<br />
             5.SATYAM<br />
            
            <br /> 
             <asp:TextBox ID="companyName" runat="server"></asp:TextBox>
             <br />
            
            <br /> 
            
            <asp:Label ID="lblmessage" runat="server"></asp:Label>
            
             <br />
                           
            <asp:Button ID="btnservice" runat="server" onClick="btnservice_Click"  Text="Get Stock" style="width:99px" />

             <br />
             <br />
            
         </div>
      </form>
</body>
</html>
