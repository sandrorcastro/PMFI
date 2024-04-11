using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcGruposQuotasNatureza
{
    public short IdGrupo { get; set; }

    public string CdNatDespesa { get; set; } = null!;

    public virtual TbOrcGruposQuota IdGrupoNavigation { get; set; } = null!;
}
