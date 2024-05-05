using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class MovImovei
{
    public int MovImoNumLanc { get; set; }

    public string? MovImoCnpjfilial { get; set; }

    public string? MovImoInscricao { get; set; }

    public int? MovImoNumFicha { get; set; }

    public DateTime? MovImoDtmov { get; set; }

    public string? MovImoTransacao { get; set; }

    public decimal? MovImoMetragem { get; set; }

    public string? MovImoOcupacao { get; set; }

    public string? MovImoFuncionario { get; set; }

    public virtual Imovei? Imovei { get; set; }
}
