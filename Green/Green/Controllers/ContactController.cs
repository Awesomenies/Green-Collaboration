using Green.Models.Entity;
using Green.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green.Controllers
{
    public class ContactController : Controller
    {
        private Entity db = new Entity();
        // GET: Contact
        public ActionResult Index(string Name, string Email, string Text, string Newsletter)
        {
            VmContact wm = new VmContact();
            wm.Contacts = db.Contacts.ToList();
            wm.ContactSliders = db.ContactSliders.ToList();
            wm.ContactTexts = db.ContactTexts.ToList();
            wm.NewsLetters = db.NewsLetters.ToList();

            return View(wm);
        }
    }
}