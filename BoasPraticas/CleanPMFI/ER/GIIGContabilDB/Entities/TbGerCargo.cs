using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerCargo
{
    public int IdCargo { get; set; }

    public string? DsCargo { get; set; }

    public string? DsTipo { get; set; }

    public virtual ICollection<TbGerCargosServidore> TbGerCargosServidores { get; set; } = new List<TbGerCargosServidore>();
}
