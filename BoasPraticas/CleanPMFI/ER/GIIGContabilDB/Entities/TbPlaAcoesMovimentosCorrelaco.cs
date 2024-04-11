using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaAcoesMovimentosCorrelaco
{
    public int IdMovimentoCorrelacao { get; set; }

    public int? IdAcao { get; set; }

    public int? IdMovimento { get; set; }

    public int? IdVersaoMovimento { get; set; }
}
