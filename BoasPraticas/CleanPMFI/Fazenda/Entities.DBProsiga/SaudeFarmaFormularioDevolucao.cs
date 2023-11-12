using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeFarmaFormularioDevolucao
{
    public long IdFormulario { get; set; }

    public DateTime? DataMov { get; set; }

    public string? HoraMov { get; set; }

    public long? IdTipoMov { get; set; }

    public long? IdEstoqueSaida { get; set; }

    public long? IdAlmoxDestino { get; set; }

    public string? Usuario { get; set; }

    public virtual ICollection<SaudeFarmaFormularioDevolucaoIten> SaudeFarmaFormularioDevolucaoItens { get; set; } = new List<SaudeFarmaFormularioDevolucaoIten>();
}
