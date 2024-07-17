using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class Declaraco
    {
        public int IdConta { get; set; }
        public int IdEmpresa { get; set; }
        public decimal ValorTotal { get; set; }
        public byte NrCompetencia { get; set; }
        public short AnoCompetencia { get; set; }
        public DateTime DtLcto { get; set; }
        public string TipoConta { get; set; } = null!;
        public string? Observacao { get; set; }
        public string? Idusuario { get; set; }
        public string? UsuarioAdministrador { get; set; }
        public string TipoRecolhimento { get; set; } = null!;
        public DateTime? DataPagamento { get; set; }
        public int? IdcontaEstorno { get; set; }
        public string? TipoDeclaracao { get; set; }
        public string? Status { get; set; }
        public string? Erros { get; set; }
        public int? NrNota { get; set; }
        public DateTime? DtCompetencia { get; set; }
        public decimal? ValorIssretido { get; set; }
        public decimal? ValorTotalIss { get; set; }
        public decimal? ValorServico { get; set; }
        public string? Regime { get; set; }
        public string? Servico { get; set; }
        public string? NomeContribuinte { get; set; }
        public string? CpfCnpjcontribuinte { get; set; }
        public long? IdNfseSubstituta { get; set; }
        public string? SituacaoNota { get; set; }
    }
}
