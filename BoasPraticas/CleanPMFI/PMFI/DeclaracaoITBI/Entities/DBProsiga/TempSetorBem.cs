using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TempSetorBem
{
    public int CodSetor { get; set; }

    public string? NomeSetor { get; set; }

    public virtual ICollection<TempCadBem> TempCadBems { get; set; } = new List<TempCadBem>();
}
