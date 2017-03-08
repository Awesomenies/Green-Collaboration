using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Green.Models.Entity;
using Green.Models.User;

namespace Green.Controllers
{
    public class AccountController : Controller
    {
        private Entity db = new Entity();

        //UserAccount db = new UserAccount();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult registre(UserAccount account)
        {
            if (ModelState.IsValid)
            {
                using (Entity db = new Entity())
                {
                    db.UserAccounts.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.Lastname + " er blevet succesfuldt registrert.";
            }
            return View();
        }

        //Login 
        public ActionResult Login()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using (Entity db = new Entity())
            {
                var usr = db.UserAccounts.Single(u => u.Email == user.Email && u.Password == user.Password);
                if (usr != null)
                {
                    Session["UserID"] = usr.Id.ToString();
                    Session["Email"] = usr.Email.ToString();

                    RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Email eller password er forkert");

                }
            }

            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}