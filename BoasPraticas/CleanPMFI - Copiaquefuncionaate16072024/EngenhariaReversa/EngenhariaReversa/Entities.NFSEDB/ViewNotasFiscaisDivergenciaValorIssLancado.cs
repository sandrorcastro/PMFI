using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class ViewNotasFiscaisDivergenciaValorIssLancado
    {
        public string? RazaoSocialPrestador { get; set; }
        public string? CnpjPrestador { get; set; }
        public string? CmcPrestador { get; set; }
        public int? NrNfse { get; set; }
        public DateTime? DtEmissao { get; set; }
        public string? RazaoSocialTomador { get; set; }
        public string? CpfCnpjTomador { get; set; }
        public string? CmcTomador { get; set; }
        public decimal? ValorServicos { get; set; }
        public decimal? BaseCalculo { get; set; }
        public decimal? AliquotaInformada { get; set; }
        public decimal? Issqn { get; set; }
        public decimal? BaseCalculoRecalculado { get; set; }
        public decimal? AliquotaCorreta { get; set; }
        public decimal? IssqnRecalculado { get; set; }
        public int? Iddivida { get; set; }
        public string? SituacaoDivida { get; set; }
        public DateTime? DataBaixa { get; set; }
    }
}
