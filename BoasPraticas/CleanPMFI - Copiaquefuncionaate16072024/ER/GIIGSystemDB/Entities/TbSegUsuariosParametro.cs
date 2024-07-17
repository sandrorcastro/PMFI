using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegUsuariosParametro
{
    public string DsLogin { get; set; } = null!;

    public string NmParametro { get; set; } = null!;

    public string? DsParametro { get; set; }

    public string? VlParametro { get; set; }
}
