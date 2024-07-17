using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class VwRelSaldosOperacoesCredito
{
    public short? IdEmpresa { get; set; }

    public int? NrMes { get; set; }

    public int? NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string? CdContaContabil { get; set; }

    public string? DsTipoOperacao { get; set; }

    public decimal? VlLancado { get; set; }

    public string? CdClassificacao { get; set; }

    public int? IdClasseOperacaoCredito { get; set; }
}
