using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class TmpEncerramentoConferencium
    {
        public long Nunumero { get; set; }
        public DateTime? Dtdata { get; set; }
        public string? RegimePrestador { get; set; }
        public string? IdServico { get; set; }
        public string? NomeContribuinte { get; set; }
        public string? Cpfcnpjcontribuinte { get; set; }
        public string? Cmctomador { get; set; }
        public string? CidadeTomador { get; set; }
        public string? CidadePrestacaoServico { get; set; }
        public string? RegimeNota { get; set; }
        public decimal? Aliquota { get; set; }
        public decimal? Vlbasecalculo { get; set; }
        public string? IssRetido { get; set; }
        public decimal? Vltotaliss { get; set; }
        public decimal? Vlissretido { get; set; }
        public decimal? Vlservicos { get; set; }
        public decimal? Vltotalliquido { get; set; }
        public long? Iddivida { get; set; }
    }
}
