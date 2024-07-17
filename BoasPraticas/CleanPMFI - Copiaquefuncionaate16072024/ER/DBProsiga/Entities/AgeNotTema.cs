using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AgeNotTema
{
    public int TemaId { get; set; }

    public string? TemaDescricao { get; set; }

    public virtual ICollection<AgeNotNoticia> AgeNotNoticia { get; set; } = new List<AgeNotNoticia>();
}
