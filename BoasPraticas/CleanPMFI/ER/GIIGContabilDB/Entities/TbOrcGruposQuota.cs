using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcGruposQuota
{
    public short IdGrupo { get; set; }

    public short? IdEmpresa { get; set; }

    public string? DsGrupo { get; set; }

    public bool? FlLimitaRms { get; set; }

    public bool? FlLimitaSolicitacao { get; set; }

    public bool? FlLimitaEmpenho { get; set; }

    public virtual ICollection<TbOrcGruposQuotasNatureza> TbOrcGruposQuotasNaturezas { get; set; } = new List<TbOrcGruposQuotasNatureza>();

    public virtual ICollection<TbOrcQuotasOrcamentaria> TbOrcQuotasOrcamentaria { get; set; } = new List<TbOrcQuotasOrcamentaria>();
}
