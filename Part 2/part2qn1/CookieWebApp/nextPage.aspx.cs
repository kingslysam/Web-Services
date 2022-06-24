using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieWebApp
{
    public partial class nextPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cookie"];
            if (cookie != null)
            {
                Label1.Text = "Cookie is: " + cookie["UserName"];
            }
            else
            {
                Label1.Text = "No cookies found.";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cookie"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
                Response.Redirect("userin.aspx");
            }
            else
            {
                Response.Redirect("userin.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userin.aspx");
        }
    }
}