using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class indexOutofRange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] array = { 12, 65, 89, 7, 8, 55, 74, 1, 2 };
            int i;
            int s;
            bool res1 = int.TryParse(enternum.Text, out i);
            bool res2 = int.TryParse(enterIndex.Text, out s);

            if (!res1 && !res2)
            {
                checklabeled.Text = "Put in a number for both:";
            }
            else
            {
                try
                {
                    array[s - 1] = i;
                    checklabeled.Text = "Accepted, The Array " + String.Join(",", array);
                }
                catch (IndexOutOfRangeException ex)
                {
                    checklabeled.Text = "Error: Index out of range: \nTry Again: index from 0 to "+array.Length;
                    Response.Redirect("customPage.aspx");
                }
            }
        }
    }
}