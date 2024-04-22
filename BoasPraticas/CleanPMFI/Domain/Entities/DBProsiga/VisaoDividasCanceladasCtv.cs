using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class VisaoDividasCanceladasCtv
    {
        public long AutiId { get; set; }
        public DateTime? AutiDataAuto { get; set; }
        public long? AutiNumNotificacao { get; set; }
        public DateTime? AutiDataNotificacao { get; set; }
        public decimal AuItValor { get; set; }
        public int? TipoBxId { get; set; }
        public string? TipoBxNome { get; set; }
        public string DivMotivoBaixa { get; set; } = null!;
        public long? InfrId { get; set; }
    }
}
