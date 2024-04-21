using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class ItensManutencaoMovEquip
{
    public long MovEquipId { get; set; }

    public int CompServId { get; set; }

    public DateTime? DataManutencao { get; set; }

    public int? ValDuracaoDias { get; set; }

    public DateTime? DtProxManut { get; set; }

    public virtual ComponentesServico CompServ { get; set; } = null!;

    public virtual MoveisEquipamento MovEquip { get; set; } = null!;
}
