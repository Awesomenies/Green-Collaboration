using Green.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green.Models.ViewModels
{
    public class VmBlog
    {
        public virtual Blog Blog { get; set; }
        public virtual List<Blog> Blogs { get; set; }
        public virtual BlogText BlogText { get; set; }
        public virtual List<BlogText> BlogTexts { get; set; }
        public virtual BlogSlider BlogSlider { get; set; }
        public virtual List<BlogSlider> BlogSliders { get; set; }
        public virtual BlogComment BlogComment { get; set; }
        public virtual List<BlogComment> BlogComments { get; set; }



        public virtual BlogLike BlogLike { get; set; }
        public virtual List<BlogLike> BlogLikes { get; set; }

        public virtual News News { get; set; }
        public virtual List<News> Newss { get; set; }

        public virtual NewsComment NewsComment { get; set; }
        public virtual List<NewsComment> NewsComments { get; set; }

        public virtual NewsLike NewsLike { get; set; }
        public virtual List<NewsLike> NewsLikes { get; set; }

        public virtual Ads Ads { get; set; }
        public virtual List<Ads> Adses { get; set; }

        public virtual Text Text { get; set; }
        public virtual List<Text> Texts { get; set; }
        public virtual Slider Slider { get; set; }
        public virtual List<Slider> Sliders { get; set; }

    }
}