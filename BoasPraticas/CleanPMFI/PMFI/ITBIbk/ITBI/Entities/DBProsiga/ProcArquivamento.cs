﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class ProcArquivamento
{
    public long ArquivId { get; set; }

    public long? ArqLocalFisicoId { get; set; }

    public long? ArqArmario { get; set; }

    public long? ArqPrateleira { get; set; }

    public long? ArqCaixa { get; set; }

    public virtual LocalFisico? ArqLocalFisico { get; set; }

    public virtual ICollection<Processo> Processos { get; set; } = new List<Processo>();
}
