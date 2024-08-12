using System;
using System.Web.UI;
using LibraryManagementSystem.Common;

namespace LibraryManagementSystem.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPreRender(EventArgs e)
        {
            lblPageTitle.Text = PageTitleConstants.MAIN_PAGE_TITLE;

            base.OnPreRender(e);
        }
    }
}