using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SerIturDatasHistorica
{
    public long DataHistId { get; set; }

    public DateTime? DataHistData { get; set; }

    public string? DataHistDescricao { get; set; }

    public virtual ICollection<SerIturAtrativosTuristico> Atrativos { get; set; } = new List<SerIturAtrativosTuristico>();
}
