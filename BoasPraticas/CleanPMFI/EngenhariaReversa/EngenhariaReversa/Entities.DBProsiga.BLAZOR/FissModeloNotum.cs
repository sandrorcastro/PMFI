using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FissModeloNotum
    {
        public FissModeloNotum()
        {
            FissDocFiscais = new HashSet<FissDocFiscai>();
        }

        public int ModNotaId { get; set; }
        public string? ModNota { get; set; }

        public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; }
    }
}
