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
    DataProcess dt = new DataProcess();
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
   
    [WebMethod]
    public bool CheckLogin (string username ,string pass)
    {
        return dt.CheckLogin(username,pass);
    }

    [WebMethod]
    public string getAccount(string code)
    {
        return dt.getAccount(code);
    }
    [WebMethod]
    public bool takemoney(string code,string money)
    {
        return dt.takemoney(code, money);
    }
    [WebMethod]
    public bool transfer(string code,string code2, string money)
    {
        return dt.transfer(code, code2 ,money);

    }

}