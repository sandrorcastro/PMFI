using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTempParcelamento
    {
        public string? TempSessao { get; set; }
        public long? ImoIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ConIddivida { get; set; }
        public decimal? ValorPrincipal { get; set; }
        public decimal? ValorCorrecao { get; set; }
        public decimal? ValorJuros { get; set; }
        public decimal? ValorMulta { get; set; }
        public decimal? ValorMultaDa { get; set; }
        public decimal? ValorDesconto { get; set; }
        public decimal? ValorTotal { get; set; }
        public int? TipoTribId { get; set; }
        public DateTime? Vencimento { get; set; }
        /// <summary>
        /// Edificação que originou o TAP
        /// </summary>
        public int? EdificacaoIdorigem { get; set; }
        /// <summary>
        /// CMC que originou o TAP
        /// </summary>
        public int? EmprCmcorigem { get; set; }
        /// <summary>
        /// Contribuinte que originou o TAP
        /// </summary>
        public int? ConIdorigem { get; set; }
        public int? LeiDescId { get; set; }
        public int? TipoDivida { get; set; }
    }
}
