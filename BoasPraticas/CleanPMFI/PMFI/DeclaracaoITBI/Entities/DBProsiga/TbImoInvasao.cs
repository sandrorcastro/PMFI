using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TbImoInvasao
{
    public int IdInvasao { get; set; }

    public DateTime DtInvasao { get; set; }

    public decimal? AreaAcupadaInvasao { get; set; }

    public string? NmLoteInvasao { get; set; }

    public string? ObsInvasao { get; set; }

    public string ImoCnpjfilial { get; set; } = null!;

    public string ImoInscricao { get; set; } = null!;

    public DateTime DtUsoCapiao { get; set; }

    public virtual ImobensImovei ImobensImovei { get; set; } = null!;

    public virtual ICollection<TbDadosDaReintegracao> TbDadosDaReintegracaos { get; set; } = new List<TbDadosDaReintegracao>();
}
