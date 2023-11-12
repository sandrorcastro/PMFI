using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeFarmaFormularioDevolucaoItensEstorno
{
    public long IdItemEstorno { get; set; }

    public long? IdFormulario { get; set; }

    public string? IdLote { get; set; }

    public long? IdFabricante { get; set; }

    public long? IdMedicamento { get; set; }

    public long? IdEstoqueSaida { get; set; }

    public long? IdAlmoxEntrada { get; set; }

    public long? Qtd { get; set; }

    public long? SaldoLote { get; set; }

    public long? SaldoMedicamento { get; set; }

    public DateTime? DtMovimento { get; set; }

    public string? HrMovimento { get; set; }

    public string? Usuario { get; set; }
}
