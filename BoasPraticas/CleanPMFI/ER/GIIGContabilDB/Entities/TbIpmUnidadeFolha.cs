using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbIpmUnidadeFolha
{
    public short IdUnidade { get; set; }

    public string? NmUnidade { get; set; }

    public short? IdOrgao { get; set; }
}
