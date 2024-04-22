using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribCausasMorte
{
    public byte CausaMorteId { get; set; }

    public string? CausaMorteAlias { get; set; }

    public string? CausaMorteDescr { get; set; }

    public virtual ICollection<TribObito> TribObitos { get; set; } = new List<TribObito>();
}
