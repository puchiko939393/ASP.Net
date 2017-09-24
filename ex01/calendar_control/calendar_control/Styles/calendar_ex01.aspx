<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="calendar_ex01.aspx.vb" Inherits="calendar_control.calendar_ex01" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 468px;
        }
        .style2
        {
            font-size: x-large;
            font-family: "Arial Unicode MS";
            color: #CC6600;
        }
        .style3
        {
            width: 468px;
            height: 192px;
        }
        .style4
        {
            height: 192px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <table>
  <tr>
    <th class="style1">
        <h2 style="background-color: #CCFF33">
        <asp:Label ID="Label1" runat="server" Text="Calendar" CssClass="style2" 
                ForeColor="Black"></asp:Label>
        </h2>
      </th>
    
  </tr>
  <tr>
    <td class="style3">
        <asp:Calendar ID="Calendar1" runat="server" Height="208px" 
            style="font-family: 'Microsoft JhengHei UI Light'; background-color: #FFFFCC" 
            Width="400px"></asp:Calendar>
        <asp:Label ID="Label2" runat="server" 
            style="font-size: x-large; font-family: 'Microsoft YaHei'" 
            Text="Please select a date using Calendar"></asp:Label>
      </td>
    <td class="style4"></td>
  </tr>
  <tr>
    <td class="style1">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
