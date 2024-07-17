using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaTiposAcao
{
    public short IdTipoAcao { get; set; }

    public string? DsTipoAcao { get; set; }

    public string? TpAcao { get; set; }

    public string? CdInicio { get; set; }

    public virtual ICollection<TbPlaAcoesMovimento> TbPlaAcoesMovimentos { get; set; } = new List<TbPlaAcoesMovimento>();
}
