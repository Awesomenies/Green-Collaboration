using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Green.Models.Entity;

namespace Green.Models.ViewModels
{
    public class VmHomeIndex
    {
        public virtual List<Slider> Sliders { get; set; }
        public virtual List<Tip> Tips { get; set; }
        public virtual List<Ads> Adses { get; set; }
        public virtual List<Text> Texts { get; set; }
    }
}