using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoTiposRenuncium
{
    public short IdTipoRenuncia { get; set; }

    public string? DsTipoRenuncia { get; set; }

    public virtual ICollection<TbLdoDemRenunciaReceitum> TbLdoDemRenunciaReceita { get; set; } = new List<TbLdoDemRenunciaReceitum>();
}
