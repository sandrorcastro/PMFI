﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class XTbArrecadacao
{
    public DateTime? DtArrecadacao { get; set; }

    public string? Cdcontacontabil { get; set; }

    public string? Cdreceita { get; set; }

    public decimal? Vlarrecadado { get; set; }
}
