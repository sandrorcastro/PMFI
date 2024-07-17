using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRelExecucoesRelatorio
{
    public int IdExecucao { get; set; }

    public short IdRelatorio { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string TpPeriodo { get; set; } = null!;

    public short NrPeriodo { get; set; }

    public DateTime? DtBasePeriodo { get; set; }

    public DateTime? DtExecucao { get; set; }

    public string? DsLogin { get; set; }

    public string? NrEnderecoIp { get; set; }

    public string? DsNotas { get; set; }

    public bool? FlConsolidado { get; set; }

    public string? DsLogExecucao { get; set; }

    public string? DsListaOrgaos { get; set; }

    public virtual ICollection<TbRelParametrizacoesExecuco> TbRelParametrizacoesExecucos { get; set; } = new List<TbRelParametrizacoesExecuco>();
}
