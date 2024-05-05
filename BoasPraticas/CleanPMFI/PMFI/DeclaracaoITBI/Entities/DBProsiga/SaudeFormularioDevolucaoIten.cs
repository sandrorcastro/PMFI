using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeFormularioDevolucaoIten
{
    public long IdItemFormulario { get; set; }

    public long? IdFormulario { get; set; }

    public string? IdLote { get; set; }

    public long? IdFabricante { get; set; }

    public long? IdMedicamento { get; set; }

    public long? IdEstoqueSaida { get; set; }

    public long? IdAlmoxSaida { get; set; }

    public long? Qtd { get; set; }

    public long? SaldoLote { get; set; }

    public int? SaldoMedicamento { get; set; }

    public string? Status { get; set; }

    public DateTime? DtMovimento { get; set; }

    public string? HrMovimento { get; set; }

    public string? Motivo { get; set; }

    public virtual SaudeFormularioDevolucao? IdFormularioNavigation { get; set; }
}
