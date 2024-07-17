using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SeriTurUf
{
    public long Iduf { get; set; }

    public string? Ufnome { get; set; }

    public string? Regiao { get; set; }

    public long? Idpais { get; set; }

    public virtual ICollection<SeriTurOrigemTuristaCidadao> IdmovOrigems { get; set; } = new List<SeriTurOrigemTuristaCidadao>();
}
