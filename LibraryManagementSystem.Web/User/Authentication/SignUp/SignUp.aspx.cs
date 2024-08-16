using System;
using System.Web.UI;

namespace LibraryManagementSystem.Web.Authentication.SignUp
{
    public partial class SignUp :Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitClick(object sender, EventArgs e)
        {
            //Get Input from the UI
            string InputUserName = Name.Text;
            string InputPassword = UserPassword.Text;
            string InputConfirmPassword = UserConfirmPassword.Text;
            string InputEmail = Email.Text;
            

            //storing in session
            Session["UserName"] = InputUserName;
            Session["Password"] = InputPassword;
            Session["ConfirmPassword"] = InputConfirmPassword;
            Session["Email"] = InputEmail;

            //Redirect to another page to display the message
            Response.Write("Data Stored in session successfully");
            Response.Redirect("~/User/Authentication/Login/LogIn");
        }
    }
}