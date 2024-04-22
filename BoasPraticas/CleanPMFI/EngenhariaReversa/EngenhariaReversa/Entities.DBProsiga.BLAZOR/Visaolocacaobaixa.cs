using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Visaolocacaobaixa
    {
        public long LocacaoId { get; set; }
        public DateTime? LcDtGeracao { get; set; }
        public DateTime? LcDataIni { get; set; }
        public DateTime? LcDataFim { get; set; }
        public string? LcHorarioIni { get; set; }
        public string? LcHorarioFim { get; set; }
        public string LbnossoNumero { get; set; } = null!;
        public decimal? BolVlrDivida { get; set; }
        public int ContribuinteId { get; set; }
        public int? LcTaxaId { get; set; }
        public string? ConNome { get; set; }
        public int TaxaId { get; set; }
        public string? TaxNome { get; set; }
        public int? TaxSubLocalId { get; set; }
        public string? SubLocNome { get; set; }
        public int TipoSubLocId { get; set; }
        public string? TsnmTipo { get; set; }
        public int? TaxPeriodoId { get; set; }
        public string? ConCnpjcpf { get; set; }
        public int? BolConvenioId { get; set; }
        public int? LcUnidadesLocacao { get; set; }
        public decimal? LcVlrEmUffi { get; set; }
        public decimal? LcValorLocacao { get; set; }
        public string? LcCategoria { get; set; }
        public int? LcAtividade { get; set; }
        public string? LcSituacao { get; set; }
        public string? LcTecAutorizacao { get; set; }
        public int TipoPagtoId { get; set; }
        public string? TipoPdescricao { get; set; }
    }
}
