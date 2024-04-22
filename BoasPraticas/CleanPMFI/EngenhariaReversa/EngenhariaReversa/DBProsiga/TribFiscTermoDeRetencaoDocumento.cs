using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscTermoDeRetencaoDocumento
    {
        public TribFiscTermoDeRetencaoDocumento()
        {
            TribFiscTermoDeDevolucaoDocumentos = new HashSet<TribFiscTermoDeDevolucaoDocumento>();
        }

        public int FiscIdtermoRetencao { get; set; }
        public int FiscIddocumento { get; set; }
        public string? FiscDevolvido { get; set; }
        public string? FiscComplemento { get; set; }

        public virtual TribFiscDocumento FiscIddocumentoNavigation { get; set; } = null!;
        public virtual TribFiscTermoDeRetencao FiscIdtermoRetencaoNavigation { get; set; } = null!;
        public virtual ICollection<TribFiscTermoDeDevolucaoDocumento> TribFiscTermoDeDevolucaoDocumentos { get; set; }
    }
}
