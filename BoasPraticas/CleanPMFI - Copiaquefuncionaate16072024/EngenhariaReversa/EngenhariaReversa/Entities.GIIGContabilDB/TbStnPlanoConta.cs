using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbStnPlanoConta
    {
        public int IdContaContabilStn { get; set; }
        public string? CdContaContabil { get; set; }
        public string? DsContaContabil { get; set; }
        public short? NrAno { get; set; }
        public string? TpNaturezaSaldo { get; set; }
        public string? DsNivelConta { get; set; }
        public string? TpSuperavitFinanceiro { get; set; }
        public string? CdInformacaoComplementar { get; set; }
        public string? DsInformacaoComplementar { get; set; }
        public string? CdContaContabilRaiz { get; set; }
    }
}
