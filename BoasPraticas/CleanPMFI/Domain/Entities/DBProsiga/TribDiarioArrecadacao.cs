using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribDiarioArrecadacao
    {
        public long DiArId { get; set; }
        public DateTime? DiArDataLanc { get; set; }
        public string? DiArTipoOperacao { get; set; }
        public string? CodReceita { get; set; }
        public decimal? DiArValor { get; set; }
        public string? DiArNomeContribuinte { get; set; }
        public string? DiArNumDocumento { get; set; }
        public string? DiArHistorico { get; set; }
        public long? BaiId { get; set; }
        public string DiArOrigemLanc { get; set; } = null!;
    }
}
