using System.Collections.Generic;

namespace Green.Models.Entity.Beregner
{
    public class UtilitieCategory
    {
        public int Id { get; set; }

        public string Cat { get; set; }
        public virtual List<Utilitie> Utilities { get; set; }
    }
}