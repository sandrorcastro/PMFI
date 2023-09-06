using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscNotaFiscaFarmacium
    {
        public TribFiscNotaFiscaFarmacium()
        {
            TribFiscNotaFiscalFarmaciaItems = new HashSet<TribFiscNotaFiscalFarmaciaItem>();
        }

        public int Nfid { get; set; }
        public DateTime? Nfdata { get; set; }
        public long? ConId { get; set; }
        public long? EmprCmc { get; set; }
        public int? Nfnumero { get; set; }

        public virtual ICollection<TribFiscNotaFiscalFarmaciaItem> TribFiscNotaFiscalFarmaciaItems { get; set; }
    }
}
