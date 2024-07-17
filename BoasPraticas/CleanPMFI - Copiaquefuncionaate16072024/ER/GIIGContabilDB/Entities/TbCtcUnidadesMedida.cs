using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtcUnidadesMedida
{
    public int IdUnidadeMedida { get; set; }

    public string? DsUnidadeMedida { get; set; }

    public virtual ICollection<TbCtcCriterio> TbCtcCriterios { get; set; } = new List<TbCtcCriterio>();
}
