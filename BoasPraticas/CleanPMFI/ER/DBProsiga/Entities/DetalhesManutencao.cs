using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class DetalhesManutencao
{
    public long DetMvid { get; set; }

    public int? DetMvcompServId { get; set; }

    public long? DetMvmanId { get; set; }

    public string? DetMvdescricao { get; set; }

    public int? DetMvqtde { get; set; }

    public decimal? DetMvvlrTotal { get; set; }

    public virtual ComponentesServico? DetMvcompServ { get; set; }

    public virtual ManutencaoVeiculo? DetMvman { get; set; }
}
