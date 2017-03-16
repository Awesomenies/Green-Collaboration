using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green.Models.Entity
{
    public class Blog
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string Author { get; set; }
        public string Headline { get; set; }
        public string Text { get; set; }
        public string ImgUrl { get; set; }

    }

    public class BlogText
    {
        public int Id { get; set; }
        public string HeadLineText { get; set; }
        public string Text { get; set; }
    }

    public class BlogSlider
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagesUrl { get; set; }
        public bool Active { get; set; }

    }

    public class BlogComment
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string Author { get; set; }
        public string Comment { get; set; }

    }

    public class BlogLike
    {
        public int Id { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
    }

    


}