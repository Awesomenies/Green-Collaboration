using Green.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green.Controllers
{
    public class NewsController : Controller
    {
        private Entity db = new Entity();
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
    }
}