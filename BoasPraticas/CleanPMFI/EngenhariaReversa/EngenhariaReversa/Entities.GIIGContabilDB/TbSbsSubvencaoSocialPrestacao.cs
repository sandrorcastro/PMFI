using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsSubvencaoSocialPrestacao
    {
        public int IdPrestacao { get; set; }
        public int IdSubVencaoSocial { get; set; }
        public DateTime? DtPrestacao { get; set; }
        public DateTime? DtApresentada { get; set; }
        public short? NrPrazoAnalise { get; set; }
        public string? TpResultadoConclusivo { get; set; }
        public string? DsJustificativa { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbSbsSubvencaoSocial IdSubVencaoSocialNavigation { get; set; } = null!;
    }
}
