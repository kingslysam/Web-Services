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
            }
            else
            {
                cookieLabel.Text = "No cookies";
            }
            /*string name = nameCookie != null ? nameCookie.Value.Split('=')[1] : "undefined";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + name + "');", true);*/
        }

        protected void removeButton_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["cookie"];
            if (nameCookie != null)
            {
                nameCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(nameCookie);
            }
            else
            {
                cookieLabel.Text = "No Cookie to delete ";
            }
        }
    }
}