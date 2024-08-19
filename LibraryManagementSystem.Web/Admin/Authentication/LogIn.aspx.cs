using System;
using System.Web.UI;

namespace LibraryManagementSystem.Web.Admin.Authentication
{
    public partial class LogIn : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonClick(object sender, EventArgs e)
        {
            string AdminConfirmLoginId = AdminLoginId.Text;
            string AdminConfirmPassword = AdminLoginPassword.Text;

            string AdminID = "Admin";
            string AdminPassword = "123";

            if(AdminConfirmLoginId == AdminID && AdminConfirmPassword == AdminPassword) 
            {
                Response.Write("Login SuccessFully");
            }
        }
    }
}