﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscDevoluco
{
    public int DevId { get; set; }

    public int? ApreId { get; set; }

    public DateTime? DevData { get; set; }

    public string? DevItens { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public virtual TribFiscApreenso? Apre { get; set; }
}
