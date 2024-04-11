using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class VwRelSaldosReceitasIrpfdeduco
{
    public short? IdEmpresa { get; set; }

    public short NrMes { get; set; }

    public short? NrAno { get; set; }

    public string? CdReceita { get; set; }

    public decimal? VlArrecadado { get; set; }
}
