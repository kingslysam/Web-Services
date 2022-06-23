using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieWebApp
{
    public partial class userin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void enterButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cookie");
            cookie["UserName"] = uname.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("nextPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("nextPage.aspx");
        }
    }
}