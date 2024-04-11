using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class EdutipoSerie
{
    public long TipoSerId { get; set; }

    public string? TipoSerNome { get; set; }

    public virtual ICollection<Eduserie> Eduseries { get; set; } = new List<Eduserie>();
}
