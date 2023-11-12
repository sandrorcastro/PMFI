using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Simamtributo
{
    public int TribAmcodigo { get; set; }

    public string? TribDescricao { get; set; }

    public virtual ICollection<SimamtributosEquivalencium> SimamtributosEquivalencia { get; set; } = new List<SimamtributosEquivalencium>();
}
