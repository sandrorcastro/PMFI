using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class ViewNotasFiscaisDivergenciaValorSemLcto
    {
        public string? RazaoSocialPrestador { get; set; }
        public string? CnpjPrestador { get; set; }
        public string? CmcPrestador { get; set; }
        public int? NrNfse { get; set; }
        public DateTime? DtEmissao { get; set; }
        public string? RazaoSocialTom { get; set; }
        public string? CpfCnpjTom { get; set; }
        public string? CmcTom { get; set; }
        public decimal? ValorServicos { get; set; }
        public decimal? BaseCalculo { get; set; }
        public decimal? AliquotaInformada { get; set; }
        public decimal? Issqn { get; set; }
        public decimal? BaseCalculoRecalculado { get; set; }
        public decimal? AliquotaCorreta { get; set; }
        public decimal? IssqnRecalculado { get; set; }
    }
}
