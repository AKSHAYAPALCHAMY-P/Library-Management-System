using System;
using System.Web.UI;
using LibraryManagementSystem.Common;
using LibraryManagementSystem.Logic;

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
            UserDto user = new UserDto()
            {
                Name = Name.Text,
                Email = Email.Text,
                Password = UserPassword.Text,
                ConfirmPassword = UserConfirmPassword.Text
            };

            IAuthenticationFacade facade = new AuthenticationFacade();

            bool bIsSuccess = facade.Register(user);

            if(!bIsSuccess)
            {
                Response.Write("Invalid Credentials");
                Response.Redirect("~/User/Authentication/Signup/Signup");

                return;
            }

            //Redirect to another page to display the message
            Response.Write("Data Stored in session successfully");
            Response.Redirect("~/User/Authentication/Login/LogIn");
        }
    }
}