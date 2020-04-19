using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public double CelciusToReamur(int C)
    {
        return (0.8) * C;
    }
    [WebMethod]
    public double CelciusToFahrenhet(int C)
    {
        return (1.8) * C + 32;
    }
    [WebMethod]
    public double CelciusToKelvin(int C)
    {
        return C + 273;
    }
    
}