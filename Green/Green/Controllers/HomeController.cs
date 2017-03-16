using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Green.Models.Entity;
using Green.Models.ViewModels;

namespace Green.Controllers
{
    public class HomeController : Controller
    {
        private Entity db = new Entity();

        public ActionResult Index()
        {
            VmHomeIndex vm = new VmHomeIndex();

            vm.Sliders = db.Sliders.ToList();
            vm.Tips = db.Tips.ToList();
            vm.Adses = db.Adses.ToList();
            vm.Texts = db.Texts.ToList();
            
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
      
    }
}