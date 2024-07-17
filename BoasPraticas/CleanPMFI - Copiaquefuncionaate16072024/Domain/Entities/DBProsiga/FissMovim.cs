using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class FissMovim
    {
        public FissMovim()
        {
            FissDocFiscais = new HashSet<FissDocFiscai>();
            FissMovimImgs = new HashSet<FissMovimImg>();
        }

        public long MovId { get; set; }
        public DateTime? MovData { get; set; }
        public string? MovMotivo { get; set; }
        public int? TipoOpId { get; set; }

        public virtual FissTipoOperacao? TipoOp { get; set; }
        public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; }
        public virtual ICollection<FissMovimImg> FissMovimImgs { get; set; }
    }
}
