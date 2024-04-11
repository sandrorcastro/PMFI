using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspInscricaoRestosApagar
{
    public int IdInscricao { get; set; }

    public short IdEmpresa { get; set; }

    public short NrExercicio { get; set; }

    public int IdEmpenho { get; set; }

    public decimal? VlProcessadoEmLiquidacao { get; set; }

    public decimal? VlProcessado { get; set; }

    public decimal? VlNaoProcessado { get; set; }

    public DateTime? DtInscricao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbDspEmpenho IdEmpenhoNavigation { get; set; } = null!;
}
