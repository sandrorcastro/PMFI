using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeLote
{
    public string IdentLote { get; set; } = null!;

    public int CdFabricante { get; set; }

    public int CdMedicamento { get; set; }

    public DateTime? DtFabricacao { get; set; }

    public DateTime? DtValidade { get; set; }

    public string? NomeComercial { get; set; }

    public virtual ICollection<SaudeAlmoxSaldoInicial> SaudeAlmoxSaldoInicials { get; set; } = new List<SaudeAlmoxSaldoInicial>();

    public virtual ICollection<SaudeFarmaSaldoInicial> SaudeFarmaSaldoInicials { get; set; } = new List<SaudeFarmaSaldoInicial>();
}
