using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

    }


    string[,] stocks =
    {
      {"RELIND", "Reliance Industries", "1060.15"},
      {"ICICI", "ICICI Bank", "911.55"},
      {"JSW", "JSW Steel", "1201.25"},
      {"WIPRO", "Wipro Limited", "1194.65"},
      {"SATYAM", "Satyam Computers", "91.10"}
   };

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public double GetPrice(string symbol)
    {
        for (int i = 0; i < stocks.GetLength(0); i++)
        {
            if (String.Compare(symbol, stocks[i, 0], true) == 0)
                return Convert.ToDouble(stocks[i, 2]);
        }

        return 0;
    }

    [WebMethod]
    public string GetName(string symbol)
    {

        for (int i = 0; i < stocks.GetLength(0); i++)
        {
            if (String.Compare(symbol, stocks[i, 0], true) == 0)
                return stocks[i, 1];
        }

        return "Stock Not Found";

    }
}