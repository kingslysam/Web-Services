using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SOAP.ServiceReference1;

namespace SOAP
{
    public partial class client : System.Web.UI.Page
    {
        WebService1SoapClient obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int up = Convert.ToInt32(upperBoundBox.Text);
            int low = Convert.ToInt32(lowerBoundBox.Text);
            int randomNumber = obj.RandomNumberGenerator(low, up);
            randomNumberLabel.Text = (randomNumber).ToString();
        }
    }
}