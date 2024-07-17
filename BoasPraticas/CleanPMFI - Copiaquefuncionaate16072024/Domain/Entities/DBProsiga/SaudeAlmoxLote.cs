using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeAlmoxLote
    {
        public SaudeAlmoxLote()
        {
            SaudeAlmoxSaldoInicials = new HashSet<SaudeAlmoxSaldoInicial>();
        }

        public long IdAlmoxarifado { get; set; }
        public string IdentLote { get; set; } = null!;
        public int IdFabricante { get; set; }
        public int IdMedicamento { get; set; }
        public decimal? SaldoLoteAlmoxarifado { get; set; }

        public virtual ICollection<SaudeAlmoxSaldoInicial> SaudeAlmoxSaldoInicials { get; set; }
    }
}
