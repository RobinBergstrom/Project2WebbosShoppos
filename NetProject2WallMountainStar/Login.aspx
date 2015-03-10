<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NetProject2WallMountainStar.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/FirstStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 50%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="LoginForm">
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label_Username" runat="server" Text="Username: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_Username" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label_Password" runat="server" Text="Password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_Password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button_Login" runat="server" Text="Login" OnClick="Button_Login_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
