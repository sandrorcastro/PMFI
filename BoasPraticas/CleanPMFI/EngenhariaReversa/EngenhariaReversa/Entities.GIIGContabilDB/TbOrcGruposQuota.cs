using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcGruposQuota
    {
        public TbOrcGruposQuota()
        {
            TbOrcGruposQuotasNaturezas = new HashSet<TbOrcGruposQuotasNatureza>();
            TbOrcQuotasOrcamentaria = new HashSet<TbOrcQuotasOrcamentaria>();
        }

        public short IdGrupo { get; set; }
        public short? IdEmpresa { get; set; }
        public string? DsGrupo { get; set; }
        public bool? FlLimitaRms { get; set; }
        public bool? FlLimitaSolicitacao { get; set; }
        public bool? FlLimitaEmpenho { get; set; }

        public virtual ICollection<TbOrcGruposQuotasNatureza> TbOrcGruposQuotasNaturezas { get; set; }
        public virtual ICollection<TbOrcQuotasOrcamentaria> TbOrcQuotasOrcamentaria { get; set; }
    }
}
