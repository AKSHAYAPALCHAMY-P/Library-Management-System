<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBooks.aspx.cs" Inherits="LibraryManagementSystem.Web.Admin.ManageBooks.AddBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Add Books</h1>
        <div>
            <asp:Label ID="BookNumber" runat="server">Book.Id:</asp:Label>
            <asp:TextBox ID="Id" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="BookName" runat="server">BookName:</asp:Label>
            <asp:TextBox ID ="NameOfTheBook" runat="server" ></asp:TextBox><br /><br />

            <asp:Label ID="Author" runat="server">Author:</asp:Label>
            <asp:TextBox ID="AuthorName" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="BookPublishedYear" runat="server">PublishedYear:</asp:Label>
            <asp:TextBox ID="PublishedYear" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_button" />
        </div>
    </form>
</body>
</html>
