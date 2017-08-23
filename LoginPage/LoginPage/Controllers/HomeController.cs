using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users u)
        {
            if (ModelState.IsValid)
            {
                using(LoginPageEntities db = new LoginPageEntities())
                {
                    var v = db.Users.Where(a => a.UserName.Equals(u.UserName) && a.Password.Equals(u.Password)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["UserID"] = v.Id.ToString();
                        Session["UserFullName"] = v.FullName.ToString();
                        return RedirectToAction("AfterLogin");
                    }
                }
            }
            return View(u);
        }

        public ActionResult AfterLogin()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
                return RedirectToAction("Index");
        }
    }
}