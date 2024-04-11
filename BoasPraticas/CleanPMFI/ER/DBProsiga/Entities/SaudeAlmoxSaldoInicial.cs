using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeAlmoxSaldoInicial
{
    public long IdConfiguraEstoque { get; set; }

    public long? IdAlmox { get; set; }

    public int? IdFabricante { get; set; }

    public string? IdentLote { get; set; }

    public int? IdMedicamento { get; set; }

    public DateTime? DtFabricacao { get; set; }

    public DateTime? DtValidade { get; set; }

    public long? Quant { get; set; }

    public string? Usuario { get; set; }

    public DateTime? DataLcto { get; set; }

    public string? NomeComercial { get; set; }

    public decimal? Custo { get; set; }

    public virtual SaudeLote? Id { get; set; }

    public virtual Almoxarifado? IdAlmoxNavigation { get; set; }

    public virtual SaudeFabricante? IdFabricanteNavigation { get; set; }

    public virtual SaudeMedicamentoXxxxxx? IdMedicamentoNavigation { get; set; }

    public virtual SaudeAlmoxLote? IdNavigation { get; set; }
}
