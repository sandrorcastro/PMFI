using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribCausasMorte
    {
        public TribCausasMorte()
        {
            TribObitos = new HashSet<TribObito>();
        }

        public byte CausaMorteId { get; set; }
        public string? CausaMorteAlias { get; set; }
        public string? CausaMorteDescr { get; set; }

        public virtual ICollection<TribObito> TribObitos { get; set; }
    }
}
