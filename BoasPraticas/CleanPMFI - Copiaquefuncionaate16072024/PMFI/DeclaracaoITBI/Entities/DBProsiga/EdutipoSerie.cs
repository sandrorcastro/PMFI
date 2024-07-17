using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class EdutipoSerie
{
    public long TipoSerId { get; set; }

    public string? TipoSerNome { get; set; }

    public virtual ICollection<Eduserie> Eduseries { get; set; } = new List<Eduserie>();
}
