using System;
using System.Web.UI;


namespace LibraryManagementSystem.Web.Authentication.LogIn
{
    public partial class LogIn :Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string UserInputName = Session["UserName"].ToString();
            string UserPassword = Session["Password"].ToString();

            string UserName = UserInput.Text;
            string UserInputPassword = Password.Text;

            if(UserInputName == UserName && UserPassword == UserInputPassword) 
            {
                Response.Write("Login Successful!");
            }
            else
            {
                Response.Write("User not found!");
            }
        }
    }
}