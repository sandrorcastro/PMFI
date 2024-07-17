using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcGruposQuotasNatureza
    {
        public short IdGrupo { get; set; }
        public string CdNatDespesa { get; set; } = null!;

        public virtual TbOrcGruposQuota IdGrupoNavigation { get; set; } = null!;
    }
}
