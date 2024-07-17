using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSysObjetosContabei
{
    public string CdObjeto { get; set; } = null!;

    public string? NmClasse { get; set; }

    public string? NmAnterior { get; set; }

    public string? DsSiglasIntegracao { get; set; }

    public virtual ICollection<TbSysFilasContabei> TbSysFilasContabeis { get; set; } = new List<TbSysFilasContabei>();
}
