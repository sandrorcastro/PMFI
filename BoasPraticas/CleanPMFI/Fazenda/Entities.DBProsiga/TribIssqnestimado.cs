using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribIssqnestimado
{
    public long EmprCmc { get; set; }

    public int EstimIssAno { get; set; }

    public int EstimIssMes { get; set; }

    public decimal? EstimIssValorTrib { get; set; }

    public decimal? EstimIssValor { get; set; }

    public decimal? EstimIssAliquota { get; set; }

    public DateTime? EstimIssData { get; set; }

    public string? EstimIssObservacao { get; set; }

    public int? TipoTribId { get; set; }

    public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;

    public virtual TribTipoTributo? TipoTrib { get; set; }
}
