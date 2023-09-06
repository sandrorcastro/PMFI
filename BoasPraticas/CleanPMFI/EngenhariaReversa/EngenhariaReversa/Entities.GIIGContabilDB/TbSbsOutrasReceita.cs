using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsOutrasReceita
    {
        public int IdOutraReceita { get; set; }
        public int? IdSubVencaoSocial { get; set; }
        public string? CdTipoCredito { get; set; }
        public DateTime? DtCredito { get; set; }
        public decimal? VlCredito { get; set; }

        public virtual TbSbsSubvencaoSocial? IdSubVencaoSocialNavigation { get; set; }
    }
}
