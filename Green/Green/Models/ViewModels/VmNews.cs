using Green.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green.Models.ViewModels
{
    public class VmNews
    {
        public virtual Blog Blog { get; set; }
        public virtual List<Blog> Blogs { get; set; }

        public virtual BlogComment BlogComment { get; set; }
        public virtual List<BlogComment> BlogComments { get; set; }

        public virtual BlogLike BlogLike { get; set; }
        public virtual List<BlogLike> BlogLikes { get; set; }

        public virtual News News { get; set; }
        public virtual List<News> Newss { get; set; }

        public virtual NewsText NewsText { get; set; }
        public virtual List<NewsText> NewsTexts { get; set; }

        public virtual NewsSlider NewsSlider { get; set; }
        public virtual List<NewsSlider> NewsSliders { get; set; }

        public virtual NewsSliderLokalt NewsSliderLokalt { get; set; }
        public virtual List<NewsSliderLokalt> NewsSliderLokalts { get; set; }

        public virtual NewsSliderNationalt NewsSliderNationalt { get; set; }
        public virtual List<NewsSliderNationalt> NewsSliderNationalts { get; set; }


        public virtual NewsSliderIneternationalt NewsSliderIneternationalt { get; set; }
        public virtual List<NewsSliderIneternationalt> NewsSliderIneternationalts { get; set; }

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