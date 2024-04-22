using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class PubTipoDocumento
    {
        public PubTipoDocumento()
        {
            PubDocumentos = new HashSet<PubDocumento>();
        }

        public int TipoId { get; set; }
        public string? TipoDescricao { get; set; }

        public virtual ICollection<PubDocumento> PubDocumentos { get; set; }
    }
}
