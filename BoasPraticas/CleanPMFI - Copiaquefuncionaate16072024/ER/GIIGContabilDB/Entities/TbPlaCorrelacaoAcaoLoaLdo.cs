using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaCorrelacaoAcaoLoaLdo
{
    public int IdAcaoCorrelacao { get; set; }

    public int IdAcao { get; set; }

    public int? IdVersaoCorrelacao { get; set; }
}
