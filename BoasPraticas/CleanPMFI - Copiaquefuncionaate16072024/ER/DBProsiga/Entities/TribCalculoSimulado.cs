using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribCalculoSimulado
{
    public int SimuId { get; set; }

    public string? SimuDescricao { get; set; }

    public DateTime? SimuData { get; set; }

    public string? SimuPasta { get; set; }

    public short? SimuAno { get; set; }

    public virtual ICollection<TribCalculoSimuladoLanc> TribCalculoSimuladoLancs { get; set; } = new List<TribCalculoSimuladoLanc>();
}
