using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userAuthentication
{
    public partial class loginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            isInValidLabel.Text = (string)Session["invalid"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["user"] = (userBox.Text).ToLower();
            Session["password"] = passwordBox.Text;
            Response.Redirect("authentication.aspx");
        }
    }
}