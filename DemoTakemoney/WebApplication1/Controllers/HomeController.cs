using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            return View();
        }

        public ActionResult About(string user , string pass)
        {
            CheckLogin.Service check = new CheckLogin.Service();
            
            if (check.CheckLogin(user, pass))
            {
                string account = check.getAccount(user).ToString();
                string[] acc = account.Split('#');
                ViewBag.Code = acc[0];
                ViewBag.Name = acc[2];
                ViewBag.Current = acc[3];
                return View("Welcome");
            }
            else
                ViewBag.Message = "dang nhap  khong thanh cong";

            return View("index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Takemoney(string code)
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Code = code;
            return View();
        }
        public ActionResult Transfermoney(string code)
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Code = code;
            return View();
        }
        public ActionResult Status()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Actiontakemoney(string code , string money)
        {
            CheckLogin.Service trutien = new CheckLogin.Service();
            trutien.takemoney(code, money);
            ViewBag.Ok = "THANH CONG";
            return View("takemoney");
        }
        public ActionResult transfer(string code, string code2 ,string money)
        {
            CheckLogin.Service trutien = new CheckLogin.Service();
            ViewBag.Code = code;
            ViewBag.Code2 = code2;
            trutien.transfer(code, code2, money);
            return View("Transfermoney");
        }
        
    }
}