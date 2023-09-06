using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbPrjEscalaIten
    {
        public TbPrjEscalaIten()
        {
            TbPrjEscalas = new HashSet<TbPrjEscala>();
        }

        public int IdEscalaItem { get; set; }
        public string? DsItem { get; set; }

        public virtual ICollection<TbPrjEscala> TbPrjEscalas { get; set; }
    }
}
