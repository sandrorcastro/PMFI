﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaAcoesAvaliacoesAno
{
    public int IdAcao { get; set; }

    public short NrAno { get; set; }

    public decimal? NrRealizado { get; set; }

    public decimal? VlRealizado { get; set; }

    public virtual TbPlaAco IdAcaoNavigation { get; set; } = null!;
}
