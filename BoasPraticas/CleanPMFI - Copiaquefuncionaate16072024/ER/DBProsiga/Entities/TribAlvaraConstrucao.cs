using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAlvaraConstrucao
{
    public long AlvaraId { get; set; }

    public long? AlvaraNumero { get; set; }

    public int? AlvaraAno { get; set; }

    public DateTime? AlvaraData { get; set; }

    public decimal? AlvaraMetragem { get; set; }

    public string? AlavaraTipo { get; set; }

    public long? EdificacaoId { get; set; }

    public string? AlvaraSituacao { get; set; }

    public DateTime? AlavaraDataSituacao { get; set; }

    public long? AreaConstrucaoTotal { get; set; }

    public string? StatusAprovacao { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }
}
