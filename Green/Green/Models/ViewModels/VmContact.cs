using Green.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green.Models.ViewModels
{
    public class VmContact
    {
        public virtual Contact Contact { get; set; }
        public virtual List<Contact> Contacts { get; set; }
        public virtual ContactSlider ContactSlider { get; set; }
        public virtual List<ContactSlider> ContactSliders { get; set; }
        public virtual ContactText ContactText { get; set; }
        public virtual List<ContactText> ContactTexts { get; set; }
        public virtual NewsLetter NewsLetter { get; set; }
        public virtual List<NewsLetter> NewsLetters { get; set; }

    }
}