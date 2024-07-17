using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegModulosPortal
{
    public short IdModulo { get; set; }

    public string? NmModulo { get; set; }

    public string? DsModulo { get; set; }

    public short? NrOrdem { get; set; }
}
