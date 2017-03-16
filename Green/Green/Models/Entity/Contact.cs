using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green.Models.Entity
{
    public class Contact
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
    }

    public class ContactText
    {
        public int Id { get; set; }
        public string HeadLineText { get; set; }
        public string Text { get; set; }
    }

    public class ContactSlider
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagesUrl { get; set; }
        public bool Active { get; set; }
    }

    public class NewsLetter
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}