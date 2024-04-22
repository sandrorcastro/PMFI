using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeAlmoxEntradasItensExtorno
    {
        public long IdItemExtorno { get; set; }
        public string IdentLote { get; set; } = null!;
        public int Idfabricante { get; set; }
        public int Idmedicamento { get; set; }
        public int Idalmox { get; set; }
        public int Qtd { get; set; }
        public int SaldoLote { get; set; }
        public int? SaldoMedicamento { get; set; }
        public int IdAlmoxEntrada { get; set; }
        public DateTime? DtItemMovimento { get; set; }
        public string? HrItemMovimento { get; set; }
        public string? Usuario { get; set; }

        public virtual SaudeAlmoxEntrada IdAlmoxEntradaNavigation { get; set; } = null!;
    }
}
