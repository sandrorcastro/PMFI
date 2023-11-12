using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ItensManutencao
{
    public long ItMveiculoId { get; set; }

    public int ItMcompServId { get; set; }

    public long? ItMduracaoKm { get; set; }

    public long? ItMultManutencaoKm { get; set; }

    public long? ItMproxManutencaoKm { get; set; }

    public DateTime? ItMdtUltManutencao { get; set; }

    public DateTime? ItMdtProxManutencao { get; set; }

    public virtual ComponentesServico ItMcompServ { get; set; } = null!;

    public virtual Veiculo ItMveiculo { get; set; } = null!;
}
