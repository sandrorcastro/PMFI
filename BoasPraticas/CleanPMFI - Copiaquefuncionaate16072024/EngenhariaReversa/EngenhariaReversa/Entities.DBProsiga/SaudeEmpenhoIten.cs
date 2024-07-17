using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeEmpenhoIten
    {
        public long IdEmpenhoItens { get; set; }
        public long? IdEmpenho { get; set; }
        public long? IdItemEmpenho { get; set; }
        public long? QtdTotal { get; set; }
        public decimal? ValorUnitario { get; set; }
        public long? QtdRecebida { get; set; }
        public long? QtdSaldo { get; set; }
        public string? DescricaoItem { get; set; }
    }
}
