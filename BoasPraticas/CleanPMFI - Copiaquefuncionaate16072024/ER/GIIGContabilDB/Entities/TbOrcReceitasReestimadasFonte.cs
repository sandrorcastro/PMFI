using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcReceitasReestimadasFonte
{
    public int IdReestimativa { get; set; }

    public int IdFonte { get; set; }

    public decimal? VlReestimado { get; set; }
}
