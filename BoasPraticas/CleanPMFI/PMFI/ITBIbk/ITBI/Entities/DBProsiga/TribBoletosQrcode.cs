﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribBoletosQrcode
{
    public string Bolenossonumero { get; set; } = null!;

    public byte[]? BoleQrcode { get; set; }
}
