using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaTiposEscopo
{
    public short IdTipoEscopo { get; set; }

    public string? DsTipoEscopo { get; set; }

    public virtual ICollection<TbPlaEscopo> TbPlaEscopos { get; set; } = new List<TbPlaEscopo>();
}
