using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicTiposDocumento
{
    public short IdTipoDocumento { get; set; }

    public string? NmTipoDocumento { get; set; }

    public virtual ICollection<TbLicModelosDocto> TbLicModelosDoctos { get; set; } = new List<TbLicModelosDocto>();

    public virtual ICollection<TbSisQuery> IdQueries { get; set; } = new List<TbSisQuery>();
}
