using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeAlmoxLote
{
    public long IdAlmoxarifado { get; set; }

    public string IdentLote { get; set; } = null!;

    public int IdFabricante { get; set; }

    public int IdMedicamento { get; set; }

    public decimal? SaldoLoteAlmoxarifado { get; set; }

    public virtual ICollection<SaudeAlmoxSaldoInicial> SaudeAlmoxSaldoInicials { get; set; } = new List<SaudeAlmoxSaldoInicial>();
}
