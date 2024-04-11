using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaProjecoesReceitasFonte
{
    public int IdProjecao { get; set; }

    public int IdFonte { get; set; }

    public short? CdArea { get; set; }

    public decimal? VlEstimado { get; set; }
}
