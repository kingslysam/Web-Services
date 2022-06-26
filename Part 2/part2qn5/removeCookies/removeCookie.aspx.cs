using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace removeCookies
{
    public partial class removeCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["cookie"];
            if (nameCookie != null)
            {
                cookieLabel.Text = nameCookie["UserName"];
                cookiePresence.Text = "Cookie present";
            }
            else
            {
                cookiePresence.Text = "No cookies";
                cookieLabel.Text = "null";
            }
            
        }

        protected void removeButton_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["cookie"];
            if (nameCookie != null)
            {
                nameCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(nameCookie);
                cookiePresence.Text = "Cookie Removed" ;
                cookieLabel.Text = "null";
            }
            else
            {
                cookiePresence.Text = "No Cookie to delete ";
                cookieLabel.Text = "No cookies";
            }
            //Response.Redirect("removeCookie.aspx");
        }
    }
}