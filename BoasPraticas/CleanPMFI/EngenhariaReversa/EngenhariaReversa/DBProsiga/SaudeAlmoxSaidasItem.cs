using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeAlmoxSaidasItem
    {
        public long IdSaidaItem { get; set; }
        public long IdSaida { get; set; }
        public long IdAlmox { get; set; }
        public long IdMedicamento { get; set; }
        public string IdLote { get; set; } = null!;
        public long IdFabricante { get; set; }
        public long? Quant { get; set; }
        public long? SaldoLote { get; set; }
        public int? SaldoMedicamento { get; set; }
        public DateTime? DtMovimento { get; set; }
        public string? HrMovimento { get; set; }
        public string? Status { get; set; }
        public long? Saldo { get; set; }

        public virtual SaudeAlmoxSaida IdSaidaNavigation { get; set; } = null!;
    }
}
