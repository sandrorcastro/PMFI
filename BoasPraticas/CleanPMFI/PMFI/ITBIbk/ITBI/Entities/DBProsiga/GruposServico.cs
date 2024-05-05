using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class GruposServico
{
    public int GsvId { get; set; }

    public string? GsvNome { get; set; }

    public virtual ICollection<Formulario> Formularios { get; set; } = new List<Formulario>();
}
