using Green.Models.Entity;
using Green.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green.Controllers
{
    public class BlogController : Controller
    {
        private Entity db = new Entity();
        // GET: Blog
        public ActionResult Index()
        {
            VmBlog vm = new VmBlog();
            vm.Adses = db.Adses.ToList();
            vm.BlogSliders = db.BlogSliders.ToList();
            vm.BlogComments = db.BlogComments.ToList();
            vm.BlogLikes = db.BlogLikes.ToList();
            vm.Blogs = db.Blogs.ToList();
            vm.NewsComments = db.NewsComments.ToList();
            vm.NewsLikes = db.NewsLikes.ToList();
            vm.Newss = db.Newss.ToList();
            vm.Sliders = db.Sliders.ToList();
            vm.Texts = db.Texts.ToList();

            

            return View(vm);
        }
    }
}