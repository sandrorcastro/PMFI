using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FissTipoDocumento
    {
        public FissTipoDocumento()
        {
            FissDocFiscais = new HashSet<FissDocFiscai>();
        }

        public int TipoDocId { get; set; }
        public string? TipoDocNome { get; set; }

        public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; }
    }
}
