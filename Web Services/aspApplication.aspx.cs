using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Services
{
    public partial class aspApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Clicksubmit_Click(object sender, EventArgs e)
        {
            bool namecheck = string.IsNullOrEmpty(namebox.Text);
            bool techlistcheck = string.IsNullOrEmpty(techlist.SelectedValue);
            if (namecheck == false && techlistcheck == false)
            {
                empty.Text = "Your name is " + namebox.Text + " & your favourite technology is " + techlist.SelectedItem;
            }
            else if (namecheck == false && techlist.SelectedValue == "")
            {
                empty.Text = "Your name is " + namebox.Text + " No technology ";
            }
            else
            {
                empty.Text = "No name enter ";
            }
        }
    }
}