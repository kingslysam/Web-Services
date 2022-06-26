using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userAuthentication
{
    public partial class authentication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String[] username = { "samuel", "prudencia", "hans", "bernadette", "hashim" };
            String[] password = { "12345", "00000", "11111", "54321", "student" };
            for (int i = 0; i < username.Length; i++)
            {
                for (int j = 0; j < password.Length; j++)
                {
                    if (Session["user"].ToString() == username[i] && Session["password"].ToString() == password[j])
                    {
                        goto displayInfo;
                    }
                }
            }
            Session["invalid"] = "Invalid try again";
            Response.Redirect("loginPage.aspx");
        displayInfo:
            {
                //confirm.Text = "Succesful login";
                confirm.Text = "User Confirm \n Welcome, " + (string)Session["user"];
                Session["invalid"] = "false";
            }
        }
    } 
}