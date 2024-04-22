using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribZonaUso
    {
        public TribZonaUso()
        {
            TribZonaZoneamentoUsos = new HashSet<TribZonaZoneamentoUso>();
        }

        public short ZousId { get; set; }
        public string? ZousNome { get; set; }
        public string? ZousDescricao { get; set; }
        public short? ZotuId { get; set; }

        public virtual TribZonaTipoUso? Zotu { get; set; }
        public virtual ICollection<TribZonaZoneamentoUso> TribZonaZoneamentoUsos { get; set; }
    }
}
