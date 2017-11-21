using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index(string username,string pass)
        {
            CheckLogin.Service wc = new CheckLogin.Service();
            if(wc.CheckLogin(username,pass))
            {

                Response.Write("ok");
                return View("Welcome");
            }
            else
            {
                Response.Write("not ok");
                return View();
                
            }
           
        }



    }
}