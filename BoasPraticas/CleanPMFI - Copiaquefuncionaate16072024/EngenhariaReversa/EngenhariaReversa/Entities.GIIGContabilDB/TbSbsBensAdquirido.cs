using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsBensAdquirido
    {
        public int IdBemAdiquirido { get; set; }
        public int? IdSubVencaoSocial { get; set; }
        public string? CdTipoDocDespesa { get; set; }
        public string? NrDocDespesa { get; set; }
        public string? DsBemAdquirido { get; set; }
        public int? NrQtdBemAdquirido { get; set; }
        public decimal? VlUnitario { get; set; }

        public virtual TbSbsSubvencaoSocial? IdSubVencaoSocialNavigation { get; set; }
    }
}
