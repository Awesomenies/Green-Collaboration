using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green.Models.Entity
{
    public class Text
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Place Place { get; set; }

        public string Headline { get; set; }
        public string Textarea { get; set; }


    }
}