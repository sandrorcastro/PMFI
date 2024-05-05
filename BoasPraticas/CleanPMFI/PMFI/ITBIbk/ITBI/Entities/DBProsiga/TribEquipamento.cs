using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEquipamento
{
    public int EquipId { get; set; }

    public string? EquipNome { get; set; }

    public decimal? EquipFator { get; set; }

    public int? EquipPontos { get; set; }

    public virtual ICollection<TribEdificaco> Edificacaos { get; set; } = new List<TribEdificaco>();
}
