using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoTiposPassivosRisco
{
    public short IdRisco { get; set; }

    public string? DsRisco { get; set; }

    public virtual ICollection<TbLdoDemRiscosFiscai> TbLdoDemRiscosFiscais { get; set; } = new List<TbLdoDemRiscosFiscai>();
}
