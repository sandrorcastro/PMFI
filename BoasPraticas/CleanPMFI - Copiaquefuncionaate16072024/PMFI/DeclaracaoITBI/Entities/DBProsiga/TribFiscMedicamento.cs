using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscMedicamento
{
    public int MedId { get; set; }

    public string? MedNome { get; set; }

    public string? MedObs { get; set; }

    public virtual ICollection<TribFiscNotaFiscalFarmaciaItem> TribFiscNotaFiscalFarmaciaItems { get; set; } = new List<TribFiscNotaFiscalFarmaciaItem>();

    public virtual ICollection<TribFiscReceitaItem> TribFiscReceitaItems { get; set; } = new List<TribFiscReceitaItem>();
}
