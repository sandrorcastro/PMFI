using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCtcCriterio
    {
        public TbCtcCriterio()
        {
            TbCtcCentroCustosCriterios = new HashSet<TbCtcCentroCustosCriterio>();
        }

        public int IdCriterio { get; set; }
        public string? DsCriterio { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public short? NrAno { get; set; }
        public int? IdUnidadeMedida { get; set; }

        public virtual TbCtcUnidadesMedida? IdUnidadeMedidaNavigation { get; set; }
        public virtual ICollection<TbCtcCentroCustosCriterio> TbCtcCentroCustosCriterios { get; set; }
    }
}
