using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicPenalidade
{
    public short IdPenalidade { get; set; }

    public string? DsPenalidade { get; set; }

    public string? DsSigla { get; set; }
}
