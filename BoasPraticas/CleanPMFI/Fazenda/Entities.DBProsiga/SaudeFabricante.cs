using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeFabricante
{
    public int IdFabricante { get; set; }

    public string? FabricanteNome { get; set; }

    public string? Cnpj { get; set; }

    public int? IdEndereco { get; set; }

    public string? NroPredial { get; set; }

    public string? Complemento { get; set; }

    public virtual ICollection<SaudeAlmoxSaldoInicial> SaudeAlmoxSaldoInicials { get; set; } = new List<SaudeAlmoxSaldoInicial>();
}
