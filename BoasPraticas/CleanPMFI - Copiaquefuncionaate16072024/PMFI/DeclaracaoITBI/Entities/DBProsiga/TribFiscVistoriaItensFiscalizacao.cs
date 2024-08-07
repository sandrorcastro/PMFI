﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscVistoriaItensFiscalizacao
{
    public long ItemVistFiscId { get; set; }

    public int? VistId { get; set; }

    public int? ItemVistId { get; set; }

    public DateOnly? ItemVistFiscData { get; set; }

    public short? ItemVistFiscPrazo { get; set; }

    public string? ItemVistFiscObs { get; set; }
}
