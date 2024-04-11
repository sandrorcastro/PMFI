using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspComponentesDespesa
{
    public short IdComponente { get; set; }

    public string? CdComponente { get; set; }

    public string? NmComponente { get; set; }

    public short? IdComponenteVinculo { get; set; }

    public virtual ICollection<TbDspEmpenhosCompoentesDespesa> TbDspEmpenhosCompoentesDespesas { get; set; } = new List<TbDspEmpenhosCompoentesDespesa>();
}
