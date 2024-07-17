using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class ViewNfseIssRetidoLctoTributo9
    {
        public string? RazaoSocial { get; set; }
        public string? CmcPrestador { get; set; }
        public string? CnpjPrestador { get; set; }
        public string? CmcTomador { get; set; }
        public string? CnpjTomador { get; set; }
        public string RegimeTributacaoPrestador { get; set; } = null!;
        public string? CodServico { get; set; }
        public string? CidadeTomador { get; set; }
        public string? CidadePrestacaoServico { get; set; }
        public int? NrNfse { get; set; }
        public DateTime? NfseData { get; set; }
        public DateTime? NfseCompetencia { get; set; }
        public decimal? ValorNota { get; set; }
        public decimal? ValorBaseCalc { get; set; }
        public decimal? Aliquota { get; set; }
        public decimal? TotalIss { get; set; }
        public decimal? IssRetido { get; set; }
        public int? NrEncerramento { get; set; }
        public int? Divida { get; set; }
        public string? Tributo { get; set; }
        public decimal? ValorDivida { get; set; }
        public string? TipoBaixa { get; set; }
    }
}
