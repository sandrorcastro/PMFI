using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscMedicamento
    {
        public TribFiscMedicamento()
        {
            TribFiscNotaFiscalFarmaciaItems = new HashSet<TribFiscNotaFiscalFarmaciaItem>();
            TribFiscReceitaItems = new HashSet<TribFiscReceitaItem>();
        }

        public int MedId { get; set; }
        public string? MedNome { get; set; }
        public string? MedObs { get; set; }

        public virtual ICollection<TribFiscNotaFiscalFarmaciaItem> TribFiscNotaFiscalFarmaciaItems { get; set; }
        public virtual ICollection<TribFiscReceitaItem> TribFiscReceitaItems { get; set; }
    }
}
