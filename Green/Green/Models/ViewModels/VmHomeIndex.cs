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
    }
}