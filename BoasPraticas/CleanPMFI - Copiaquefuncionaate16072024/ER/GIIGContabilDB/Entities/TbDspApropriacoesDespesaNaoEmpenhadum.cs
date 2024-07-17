using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspApropriacoesDespesaNaoEmpenhadum
{
    public int IdApropriacao { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public short? NrMes { get; set; }

    public int? NrSequencia { get; set; }

    public int? IdLiquidacao { get; set; }
}
