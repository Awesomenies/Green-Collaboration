using System.Collections.Generic;

namespace Green.Models.Entity
{
    public class TipCategori
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Tip> Tips { get; set; }
    }
}