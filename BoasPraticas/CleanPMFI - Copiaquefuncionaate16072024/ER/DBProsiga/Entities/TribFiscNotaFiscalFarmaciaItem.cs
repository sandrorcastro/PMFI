using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscNotaFiscalFarmaciaItem
{
    public int Nfid { get; set; }

    public int MedId { get; set; }

    public int? Quant { get; set; }

    public virtual TribFiscMedicamento Med { get; set; } = null!;

    public virtual TribFiscNotaFiscaFarmacium Nf { get; set; } = null!;
}
