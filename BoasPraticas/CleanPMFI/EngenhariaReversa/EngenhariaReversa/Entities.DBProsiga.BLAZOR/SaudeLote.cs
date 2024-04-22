using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeLote
    {
        public SaudeLote()
        {
            SaudeAlmoxSaldoInicials = new HashSet<SaudeAlmoxSaldoInicial>();
            SaudeFarmaSaldoInicials = new HashSet<SaudeFarmaSaldoInicial>();
        }

        public string IdentLote { get; set; } = null!;
        public int CdFabricante { get; set; }
        public int CdMedicamento { get; set; }
        public DateTime? DtFabricacao { get; set; }
        public DateTime? DtValidade { get; set; }
        public string? NomeComercial { get; set; }

        public virtual ICollection<SaudeAlmoxSaldoInicial> SaudeAlmoxSaldoInicials { get; set; }
        public virtual ICollection<SaudeFarmaSaldoInicial> SaudeFarmaSaldoInicials { get; set; }
    }
}
