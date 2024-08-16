<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="LibraryManagementSystem.Web.Authentication.SignUp.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SignUp</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>SignUp</h1>

            <asp:Label ID="UserName" runat="server">UserName:</asp:Label>
            <asp:TextBox ID="Name" runat="server"></asp:TextBox><br />
            <br />

            <asp:Label ID="Email" runat="server">Email:</asp:Label>
            <asp:TextBox ID="UserEmail" runat="server"></asp:TextBox><br />
            <br />

            <asp:Label ID="Password" runat="server">passsword:</asp:Label>
            <asp:TextBox ID="UserPassword" runat="server"></asp:TextBox><br />
            <br />

            <asp:Label ID="ConfirmPassword" runat="server">ConfirmPassword:</asp:Label>
            <asp:TextBox ID="UserConfirmPassword" runat="server"></asp:TextBox><br />
            <br />


            <asp:Button ID="Save" runat="server" Text="Save" OnClick="btnSubmitClick" />
        </div>
    </form>
</body>
</html>
