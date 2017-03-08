using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Green.Models.Entity.Beregner;

namespace Green.Models.ViewModels
{
    public class VmUtilitie
    {
        public virtual Utilitie Utilitie { get; set; }
        public virtual UtilitieCategory UtilitieCategory { get; set; }
        public virtual List<Utilitie> Utilities { get; set; }
        public virtual List<UtilitieCategory> UtilitieCategories { get; set; }
    }
}