using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green.Models.Entity
{
    public class Ads
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ImagesUrl { get; set; }
        public virtual AdsCategori AdsCategori { get; set; }
    }
}