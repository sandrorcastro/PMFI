using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinContaContabilEstatal
    {
        public TbFinContaContabilEstatal()
        {
            IdContaContabils = new HashSet<TbFinContasContabei>();
        }

        public int IdContaContabilEstatal { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string? CdContaContabilEstatal { get; set; }
        public string? DsContaContabil { get; set; }
        public string? TpNaturazaSaldo { get; set; }
        public string? TpEscrituracao { get; set; }

        public virtual ICollection<TbFinContasContabei> IdContaContabils { get; set; }
    }
}
