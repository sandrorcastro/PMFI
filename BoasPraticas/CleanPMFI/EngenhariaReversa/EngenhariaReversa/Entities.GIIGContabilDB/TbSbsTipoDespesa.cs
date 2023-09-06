using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsTipoDespesa
    {
        public TbSbsTipoDespesa()
        {
            IdCatDespesas = new HashSet<TbSbsCategoriasDespesa>();
        }

        public int CdTipoDespesa { get; set; }
        public string? DsTipoDespesa { get; set; }
        public string? CdNatDespesa { get; set; }

        public virtual ICollection<TbSbsCategoriasDespesa> IdCatDespesas { get; set; }
    }
}
