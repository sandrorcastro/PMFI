using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspTiposObjetivoDiarium
{
    public short IdTipoObjetivoDiaria { get; set; }

    public string? DsTipoObjetivoDiaria { get; set; }

    public virtual ICollection<TbDspDiaria> TbDspDiaria { get; set; } = new List<TbDspDiaria>();
}
