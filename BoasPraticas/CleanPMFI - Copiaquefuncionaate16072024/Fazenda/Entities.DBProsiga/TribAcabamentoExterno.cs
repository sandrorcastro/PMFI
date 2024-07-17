﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribAcabamentoExterno
{
    public int AcabExtId { get; set; }

    public string? AcabExtNome { get; set; }

    public decimal? AcabExtFator { get; set; }

    public int? AcabExtPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
