using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcEstornosDotaco
{
    public int IdEstorno { get; set; }

    public int Iddotacao { get; set; }

    public DateTime? DtEstorno { get; set; }

    public short? NrSequencia { get; set; }

    public decimal? VlEstorno { get; set; }
}
