using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCtcUnidadesMedida
    {
        public TbCtcUnidadesMedida()
        {
            TbCtcCriterios = new HashSet<TbCtcCriterio>();
        }

        public int IdUnidadeMedida { get; set; }
        public string? DsUnidadeMedida { get; set; }

        public virtual ICollection<TbCtcCriterio> TbCtcCriterios { get; set; }
    }
}
