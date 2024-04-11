using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSisQuery
{
    public int IdQuery { get; set; }

    public string? NmQuery { get; set; }

    public string? DsQuery { get; set; }

    public string? DsTipoQuery { get; set; }

    public string? DsAgrapumento { get; set; }

    public virtual ICollection<TbLicTiposDocumento> IdTipoDocumentos { get; set; } = new List<TbLicTiposDocumento>();
}
