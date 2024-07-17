using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Fzbaixa
    {
        public long BxFzid { get; set; }
        public string BoleNossoNumero { get; set; } = null!;
        public DateTime? BxDataBaixa { get; set; }
        public decimal? BxFzvlrPago { get; set; }
        public int? ConvenioId { get; set; }
        public string? BxOrigem { get; set; }
        public int? TipoBxId { get; set; }
        /// <summary>
        /// Motivo da baixa.
        /// </summary>
        public string? BxMotivoBaixa { get; set; }
        public string? BxArquivo { get; set; }

        public virtual Fzboleto BoleNossoNumeroNavigation { get; set; } = null!;
        public virtual TribTipoBaixa? TipoBx { get; set; }
    }
}
