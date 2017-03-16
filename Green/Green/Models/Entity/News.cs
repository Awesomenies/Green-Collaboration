using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green.Models.Entity
{
    public class News
    {
        public int ID { get; set; }
        public DateTime CreateTime { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
    }

    public class NewsText
    {
        public int Id { get; set; }
        public string HeadLineText { get; set; }
        public string Text { get; set; }
    }

    public class NewsSlider
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagesUrl { get; set; }
        public bool Active { get; set; }
    }
    public class NewsSliderLokalt
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagesUrl { get; set; }
        public bool Active { get; set; }
    }

    public class NewsSliderNationalt
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagesUrl { get; set; }
        public bool Active { get; set; }
    }

    public class NewsSliderIneternationalt
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagesUrl { get; set; }
        public bool Active { get; set; }
    }

    public class NewsComment
    {
        public int ID { get; set; }
        public DateTime CreateTime { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }


    }

    public class NewsLike
    {
        public int ID { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

    }
    
}