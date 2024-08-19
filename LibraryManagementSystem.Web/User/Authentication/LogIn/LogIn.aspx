<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="LibraryManagementSystem.Web.Authentication.LogIn.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LogIn</h1>
            <table>
                <tr>
                    <td>
                         <asp:Label ID="UserID" runat="server">UserID:</asp:Label>
                         <asp:TextBox ID="UserInput" runat="server" ></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="UserPassword" runat="server">Password:</asp:Label>
                        <asp:TextBox ID="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
                    </td>
                </tr>
            </table>
           
        </div>
    </form>
</body>
</html>
