﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscVistoriaItensVistoriadosDivida
{
    public long IddividaVist { get; set; }

    public int? VistId { get; set; }

    public int? ItemVistId { get; set; }

    public long? DivEmpId { get; set; }
}