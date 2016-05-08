<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="Acueto_JobLogger.TestPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 77%;
        }
        .style2
        {
            width: 145px;
        }
        .style3
        {
            width: 145px;
            height: 23px;
        }
        .style4
        {
            height: 23px;
        }
        .style5
        {
        }
        .style6
        {
            height: 23px;
            width: 200px;
        }
        .style7
        {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    <asp:Label ID="lblMessage" runat="server" Text="Message :"></asp:Label>
                </td>
                <td class="style5" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:TextBox ID="txtMessage" runat="server" Width="194px" 
                       >Message</asp:TextBox>
                </td>
                <td class="style7">
                    <asp:TextBox ID="txtWarning" runat="server" Width="194px">Warning</asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtError" runat="server" Width="194px">Error</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblTypeOfLog" runat="server" Text="Type of Log :"></asp:Label>
                </td>
                <td class="style7">
                    <asp:DropDownList ID="ddlTypeLog" runat="server" Height="16px" Width="124px">
                        <asp:ListItem Selected="True" Value="0">---Select---</asp:ListItem>
                        <asp:ListItem Value="1">Data Base</asp:ListItem>
                        <asp:ListItem Value="2">File</asp:ListItem>
                        <asp:ListItem Value="3">Console</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblTypeOfMessage" runat="server" Text="Type of Message :"></asp:Label>
                </td>
                <td class="style6">
                    <asp:CheckBox ID="chkMessage" runat="server" Text="Message" />
                </td>
                <td class="style4">
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style7">
                    <asp:CheckBox ID="chkError" runat="server" Text="Error" />
                </td>
                <td>
                    <asp:Button ID="btnLogMessage" runat="server" Text="Save" Width="110px" 
                        onclick="btnLogMessage_Click" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style7">
                    <asp:CheckBox ID="chkWarning" runat="server" Text="Warning" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
