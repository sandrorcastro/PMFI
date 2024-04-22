using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeAlmoxEntradasItem
    {
        public int IdsaudeAlmoxEntradaItem { get; set; }
        public int IdAlmoxarifado { get; set; }
        public string IdentLote { get; set; } = null!;
        public int IdFabricante { get; set; }
        public int IdMedicamento { get; set; }
        public int IdAlmoxEntrada { get; set; }
        public int Qtd { get; set; }
        public int SaldoLote { get; set; }
        public int? SaldoMedicamento { get; set; }
        public decimal? PrecoUnitario { get; set; }
        public DateTime? DtItemMovimento { get; set; }
        public string? HrItemMovimento { get; set; }
        public int? Removido { get; set; }
        public int? IdEmpenhoItens { get; set; }
        public string? Status { get; set; }

        public virtual SaudeAlmoxEntrada IdAlmoxEntradaNavigation { get; set; } = null!;
    }
}
