using login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace login.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(login.Models.login userModel )
        {
            using (Database1Entities db = new Database1Entities())
            {
                var loginDetails = db.logins.Where(x => x.Name == userModel.Name && x.password == userModel.password).FirstOrDefault();
                if(loginDetails == null)
                {
                    userModel.loginerrormsg = "wrong username or password";
                    return View("Index",userModel);
                }
                else
                {
                    Session["Id"] = loginDetails.Id;
                    return RedirectToAction("Index", "Home");
                }
            }
              
        }
        //public ActionResult Logout()
        //{
        //    Session.Abandon();
        //    return RedirectToAction("Index","Login");
        //}

    }
}