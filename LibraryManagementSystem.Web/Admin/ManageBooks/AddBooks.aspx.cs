using System;
using System.Web.UI;

namespace LibraryManagementSystem.Web.Admin.ManageBooks
{
    public partial class AddBooks : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save_button(object sender, EventArgs e)
        {
            string BookNumber = BookNo.Text;
            string BookName = NameOfTheBook.Text;
            string BookAuthor = AuthorName.Text;
            string year = PublishedYear.Text;

            Session["BookNo"] = BookNumber;
            Session["BookName"] = BookName;
            Session["BookAuthor"] = BookAuthor;
            Session["Year"] = year;


            Response.Redirect("ViewBooks.aspx");

        }
    }
}