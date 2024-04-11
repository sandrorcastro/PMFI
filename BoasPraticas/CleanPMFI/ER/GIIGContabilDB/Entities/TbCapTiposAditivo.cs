using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCapTiposAditivo
{
    public short IdTipoAditivo { get; set; }

    public string? DsTipoAditivo { get; set; }

    public virtual ICollection<TbCapAditivosConvenio> TbCapAditivosConvenios { get; set; } = new List<TbCapAditivosConvenio>();
}
