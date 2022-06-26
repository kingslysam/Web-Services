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
            if (Session["userAgent"] == null)
            {
                userLabel.Text = "No UserAgent Set on current Session";
            }
            else
            {
                userLabel.Text = (string)Session["userAgent"];
            }
            if (Session["remoteIP"] == null)
            {
                remoteLabel.Text = "No RemoteIP Set on current Session";
            }
            else
            {
                remoteLabel.Text = (string)Session["remote"];
            }
            if (Session["time"] == null)
            {
                timeLabel.Text = "No Time set on current Session";
            }
            else
            {
                timeLabel.Text = (string)Session["time"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("sessionEntry.aspx");
        }
    }
}