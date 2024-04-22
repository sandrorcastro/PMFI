using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class RhtipoLicenca
    {
        public RhtipoLicenca()
        {
            Rhlicencas = new HashSet<Rhlicenca>();
        }

        public long TipoLicId { get; set; }
        public string? TipoLicNome { get; set; }

        public virtual ICollection<Rhlicenca> Rhlicencas { get; set; }
    }
}
