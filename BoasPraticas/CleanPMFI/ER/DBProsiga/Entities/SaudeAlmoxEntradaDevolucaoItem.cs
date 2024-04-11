using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeAlmoxEntradaDevolucaoItem
{
    public long IdItemFormDevolucao { get; set; }

    public long? IdFormularioDevolucao { get; set; }

    public string? IdenLote { get; set; }

    public long? IdMedicamento { get; set; }

    public long? IdFabricante { get; set; }

    public long? IdAlmox { get; set; }

    public long? QtdTotal { get; set; }

    public long? QtdRebida { get; set; }

    public long? QtdPendente { get; set; }

    public long? SaldoLote { get; set; }

    public long? SaldoMedicamento { get; set; }

    public DateTime? DtMovimento { get; set; }

    public string? HrMovimento { get; set; }
}
