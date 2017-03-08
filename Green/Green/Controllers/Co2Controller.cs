using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Green.Models.Entity;
using Green.Models.Entity.Beregner;
using Green.Models.ViewModels;

namespace Green.Controllers
{
    public class Co2Controller : Controller
    {
        Entity db = new Entity();
        // GET: CO2
        public ActionResult Index()
        {
            return View();
        }        
        
        // GET: CO2
        public ActionResult Apparat(Utilitie w)
        {
            VmUtilitie vm = new VmUtilitie();
            vm.UtilitieCategories = db.UtilitieCategories.ToList();
            vm.Utilities = db.Utilities.ToList();
            if (w != null)
            {
                ViewBag.hej = db.UtilitieCategories.Find(w.UtilitieCategoryId);
            }
            return View(vm);
        }

        [HttpPost]
        public ActionResult Apparat(int cat, int watt, string brand, string model)
        {
            VmUtilitie vm = new VmUtilitie();
            Utilitie e = new Utilitie();
            e.Usage = watt;
            e.Standard = false;
            e.UtilitieCategoryId = cat;
            e.Title = brand;
            e.Decs = model;
            
            
            db.Utilities.Add(e);
            //db.SaveChanges();

            Utilitie w = db.Utilities.FirstOrDefault(u => u.UtilitieCategoryId == cat && u.Standard);
            

            return RedirectToAction("Apparat");
        }

        // GET: CO2
        public ActionResult ElVand()
        {
            return View();
        }        
        
        // GET: CO2
        public ActionResult Co2()
        {
            return View();
        }        
        
        // GET: CO2
        public ActionResult Total()
        {
            return View();
        }
    }
}