using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicTiposCompra
{
    public short IdTipoCompra { get; set; }

    public string? NmTipoCompra { get; set; }

    public string? DsObservacao { get; set; }
}
