using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sessionDictionary
{
    public partial class sessionEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["user"] = userBox.Text;
            Session["remote"] = remoteBox.Text;
            Session["time"] = timeBox.Text;
            userBox.Visible = false;
            remoteBox.Visible = false;
            timeBox.Visible = false;
            Button1.Visible = false;
            Response.Redirect("sessionDisplay.aspx");
        }
    }
}