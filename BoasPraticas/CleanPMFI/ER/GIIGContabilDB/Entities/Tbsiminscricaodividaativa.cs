﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Tbsiminscricaodividaativa
{
    public int Idlancamento { get; set; }

    public int? Nranosequencia { get; set; }

    public int? Nrsequencia { get; set; }

    public int Idnaturezacredito { get; set; }

    public int Idtipocredito { get; set; }

    public int Idtipooperacao { get; set; }

    public int Nranobase { get; set; }

    public int Idleiato { get; set; }

    public DateTime? Dtinscricao { get; set; }

    public decimal Vlinscrito { get; set; }

    public int? Nranoinscricao { get; set; }

    public int? TapId { get; set; }
}