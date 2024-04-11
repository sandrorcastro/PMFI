using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspTiposEstornoEmpenho
{
    public short IdTipoEstornoEmpenho { get; set; }

    public string? DsTipoEstornoEmpenho { get; set; }

    public bool? FlRap { get; set; }

    public virtual ICollection<TbDspEstornosEmpenho> TbDspEstornosEmpenhos { get; set; } = new List<TbDspEstornosEmpenho>();
}
