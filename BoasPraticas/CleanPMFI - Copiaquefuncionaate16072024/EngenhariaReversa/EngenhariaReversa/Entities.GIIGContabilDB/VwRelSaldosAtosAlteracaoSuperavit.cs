using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class VwRelSaldosAtosAlteracaoSuperavit
    {
        public short Idempresa { get; set; }
        public short NrAno { get; set; }
        public int? NrMes { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string CdFuncao { get; set; } = null!;
        public string CdSubFuncao { get; set; } = null!;
        public string? CdNatDespesa { get; set; }
        public string CdFonte { get; set; } = null!;
        public string? CdFonteNormal { get; set; }
        public string? DsSituacao { get; set; }
        public decimal? VlAlteracao { get; set; }
        public string? DsSigla { get; set; }
    }
}
