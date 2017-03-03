using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green.Models.Entity
{
    public class Tip
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public virtual TipCategori TipCategori { get; set; }
    }
}