using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRelDetalhesIndex
{
    public int IdIndice { get; set; }

    public int IdDetalhe { get; set; }

    public short? NrAno { get; set; }

    public decimal? VlQuociente { get; set; }
}
