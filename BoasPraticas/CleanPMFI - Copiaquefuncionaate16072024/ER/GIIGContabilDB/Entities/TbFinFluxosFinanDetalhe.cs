using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinFluxosFinanDetalhe
{
    public int IdDetalhe { get; set; }

    public int IdFluxo { get; set; }

    public short? NrCompMes { get; set; }

    public short? NrCompAno { get; set; }

    public short? NrParcela { get; set; }

    public decimal? VlDetalhe { get; set; }

    public bool? FlExcluido { get; set; }

    public DateTime? DtExclusao { get; set; }

    public string? DsMotivoExclusao { get; set; }

    public string? DsLoginExclusao { get; set; }

    public virtual TbFinFluxosFinanceiro IdFluxoNavigation { get; set; } = null!;
}
