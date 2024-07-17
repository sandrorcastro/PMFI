using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbcategorium
{
    public int Idcategoria { get; set; }

    public string? Descricao { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Tbservico> Tbservicos { get; set; } = new List<Tbservico>();
}
