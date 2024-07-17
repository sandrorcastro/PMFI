using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbTribAvaliacoesItbienglobamento
{
    public int EdificacaoId { get; set; }

    public int IdAvaliacao { get; set; }

    public decimal? VlAreaConstruida { get; set; }

    public decimal? VlVenal { get; set; }

    public string? DsEstruturaConstrucao { get; set; }
}
