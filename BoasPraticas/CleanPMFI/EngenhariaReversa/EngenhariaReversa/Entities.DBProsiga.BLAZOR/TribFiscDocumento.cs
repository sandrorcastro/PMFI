using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribFiscDocumento
    {
        public TribFiscDocumento()
        {
            TribFiscTermoDeRetencaoDocumentos = new HashSet<TribFiscTermoDeRetencaoDocumento>();
        }

        public int FiscIddocumento { get; set; }
        public string? FiscNomeDocumento { get; set; }
        public string? FiscSituacao { get; set; }

        public virtual ICollection<TribFiscTermoDeRetencaoDocumento> TribFiscTermoDeRetencaoDocumentos { get; set; }
    }
}
