using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaTiposExecucaoAcao
{
    public short IdTipoExecucaoAcao { get; set; }

    public string? DsTipoExecucaoAcao { get; set; }

    public virtual ICollection<TbPlaAcoesMovimento> TbPlaAcoesMovimentos { get; set; } = new List<TbPlaAcoesMovimento>();
}
