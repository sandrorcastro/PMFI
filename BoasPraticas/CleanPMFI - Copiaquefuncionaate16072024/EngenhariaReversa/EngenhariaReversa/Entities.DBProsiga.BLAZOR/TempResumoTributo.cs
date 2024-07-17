using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TempResumoTributo
    {
        public short? Ano { get; set; }
        public short? TipoTribId { get; set; }
        public string? DescricaoTributo { get; set; }
        public short? TipoBxId { get; set; }
        public string? DescricaoBaixa { get; set; }
        public decimal? Soma { get; set; }
    }
}
