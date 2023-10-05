using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class ViewCavalodetroium
    {
        public int? Nunumero { get; set; }
        public DateTime? Dtdata { get; set; }
        public string RegimePrestador { get; set; } = null!;
        public string? Idservico { get; set; }
        public string? Stnome { get; set; }
        public string? Stcpfcnpj { get; set; }
        public string? SttomIm { get; set; }
        public string? CidadeTomador { get; set; }
        public string? CidadePrestação { get; set; }
        public string RegimeNota { get; set; } = null!;
        public decimal? Pcaliquota { get; set; }
        public decimal? Vlbasecalculo { get; set; }
        public string? Stissretido { get; set; }
        public decimal? Vltotaliss { get; set; }
        public decimal? Vlissretido { get; set; }
        public decimal? Vlservicos { get; set; }
        public decimal? Vltotalliquido { get; set; }
        public int? Iddivida { get; set; }
        public int? Tributo { get; set; }
        public DateTime? Vencimento { get; set; }
        public decimal? ValorDivida { get; set; }
        public int? MesDivida { get; set; }
        public int? AnoDivida { get; set; }
    }
}
