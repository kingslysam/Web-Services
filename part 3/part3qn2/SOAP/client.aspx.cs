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
        int randomNumber;
        WebService1SoapClient obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int[] lotteryNumbers = new int[6]; 
            int up = Convert.ToInt32(upperBoundBox.Text);
            int low = Convert.ToInt32(lowerBoundBox.Text);
            for (int i = 0; i < 6; i++)
            {
                int randomNumber = obj.RandomNumberGenerator(low, up);
                bool same = true;
                while (same)
                {
                    if (i == 0)
                    {
                        same = false;
                        lotteryNumbers[i] = randomNumber;
                    }
                    else
                    {
                        if (randomNumber != lotteryNumbers[i - 1])
                        {
                            lotteryNumbers[i] = randomNumber;
                            same = false;
                        }
                        else
                        {
                            int random = obj.RandomNumberGenerator(low, up);
                            randomNumber = random;
                        }
                    }
                }
                
            }
            randomNumberLabel.Text = String.Join(",",lotteryNumbers);
        }
    }
}