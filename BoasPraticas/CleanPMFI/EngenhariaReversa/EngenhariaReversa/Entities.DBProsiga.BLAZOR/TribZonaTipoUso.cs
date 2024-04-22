using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribZonaTipoUso
    {
        public TribZonaTipoUso()
        {
            TribZonaUsos = new HashSet<TribZonaUso>();
        }

        public short ZotuId { get; set; }
        public string? ZotuNome { get; set; }

        public virtual ICollection<TribZonaUso> TribZonaUsos { get; set; }
    }
}
