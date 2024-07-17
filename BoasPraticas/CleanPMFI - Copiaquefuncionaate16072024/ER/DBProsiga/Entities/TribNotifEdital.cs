using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribNotifEdital
{
    public long NotifEditalId { get; set; }

    public long? EdiDivImoId { get; set; }

    public DateTime? NotifEditalData { get; set; }

    public virtual TribDividasImoEdital? EdiDivImo { get; set; }
}
