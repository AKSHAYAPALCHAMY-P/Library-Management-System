<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="LibraryManagementSystem.Web.Admin.Authentication.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Admin Login</h1>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="AdminId" runat="server">AdminID:</asp:Label>
                        <asp:TextBox ID="AdminLoginId" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="AdminPassword" runat="server">Password:</asp:Label>
                        <asp:TextBox ID="AdminLoginPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>

            <asp:Button ID="Login" runat="server" Text="Login" OnClick="ButtonClick"/>
        </div>
    </form>
</body>
</html>
