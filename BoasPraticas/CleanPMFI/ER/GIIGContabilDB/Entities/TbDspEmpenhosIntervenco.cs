using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspEmpenhosIntervenco
{
    public int IdEmpenho { get; set; }

    public int CdIntervencao { get; set; }

    public virtual TbDspEmpenho IdEmpenhoNavigation { get; set; } = null!;
}
