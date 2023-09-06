using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerBanco
    {
        public TbGerBanco()
        {
            TbGerAgencia = new HashSet<TbGerAgencia>();
        }

        public string CdBanco { get; set; } = null!;
        public string? NrDv { get; set; }
        public string? NmBanco { get; set; }
        public string? DsTipo { get; set; }

        public virtual ICollection<TbGerAgencia> TbGerAgencia { get; set; }
    }
}
