using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class HabFoneticoLogr
{
    public string Chave { get; set; } = null!;

    public string? Rua { get; set; }

    public string? Fonetico { get; set; }

    public virtual ICollection<HabCruzamentoLogr> HabCruzamentoLogrChave1Navigations { get; set; } = new List<HabCruzamentoLogr>();

    public virtual ICollection<HabCruzamentoLogr> HabCruzamentoLogrChave2Navigations { get; set; } = new List<HabCruzamentoLogr>();
}
