using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaNaturezasAcao
{
    public short IdNaturezaAcao { get; set; }

    public string? DsNaturezaAcao { get; set; }

    public virtual ICollection<TbPlaAcoesMovimento> TbPlaAcoesMovimentos { get; set; } = new List<TbPlaAcoesMovimento>();
}
