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
        string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        protected void Page_Load(object sender, EventArgs e)
        {
            timeLabel.Text = "Will Entered Automatically";
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userBox.Text))
            {
                Session["userAgent"] = null;
            }
            else
            {
                Session["userAgent"] = userBox.Text;
            }
            if (String.IsNullOrEmpty(remoteBox.Text))
            {
                Session["remoteIP"] = null;
            }
            else
            {
                Session["remoteIP"] = remoteBox.Text;
            }
            if (String.IsNullOrEmpty(time))
            {
                Session["time"] = null;
            }
            else
            {
                Session["time"] = time;
            }
            /*userBox.Visible = false;
            remoteBox.Visible = false;
            time.Visible = false;
            Button1.Visible = false;*/
            Response.Redirect("sessionDisplay.aspx");
        }
    }
}