﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class GccTipoCreche
{
    public string TcreCnpjmembro { get; set; } = null!;

    public int TcreId { get; set; }

    public string? TcreDescr { get; set; }

    public virtual ICollection<GccCreche> GccCreches { get; set; } = new List<GccCreche>();
}
