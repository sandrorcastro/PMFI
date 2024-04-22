using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class VwEmpresa
    {
        public long EmprCmc { get; set; }
        public string? ConCnpjcpf { get; set; }
        public string? ConNome { get; set; }
        public string? ConNomeFantasia { get; set; }
        public string? ConEndereco { get; set; }
        public string? EmprSituacaoDescricao { get; set; }
        public decimal? EmprAreaAberta { get; set; }
        public decimal? AnteriorAreaConstr { get; set; }
        public string EmprEnqSimples { get; set; } = null!;
        public string? DataEntrada { get; set; }
        public string? DataSaida { get; set; }
        public int? TipoTribId { get; set; }
        public string? TipoTribNome { get; set; }
        public int? CompAno { get; set; }
        public int? CompMes { get; set; }
        public decimal ValorIss { get; set; }
        public string? TipoBxNome { get; set; }
    }
}
