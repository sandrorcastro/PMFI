using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FzparametrosVistoria
{
    public int ItemVistId { get; set; }

    public int FztipoVeicId { get; set; }

    public long FztipoVistId { get; set; }

    public virtual FztipoVeiculo FztipoVeic { get; set; } = null!;

    public virtual FztipoVistorium FztipoVist { get; set; } = null!;

    public virtual FzitensDeVistorium ItemVist { get; set; } = null!;
}
