using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Green.Models.Entity.Beregner
{
    public class Utilitie
    {
        public int Id { get; set; }
        public bool Standard { get; set; }

        public string Title { get; set; }
        public string Decs { get; set; }

        public decimal Usage { get; set; }

        public int? UtilitieCategoryId { get; set; }
        public virtual UtilitieCategory UtilitieCategory { get; set; }
    }
}