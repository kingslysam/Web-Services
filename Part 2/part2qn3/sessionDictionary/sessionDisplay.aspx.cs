using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sessionDictionary
{
    public partial class sessionDispaly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userLabel.Text = (string)Session["user"];
            remoteLabel.Text = (string)Session["remote"];
            timeLabel.Text = (string)Session["time"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("sessionEntry.aspx");
        }
    }
}