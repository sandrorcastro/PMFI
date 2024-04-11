using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcSolicitacoesSaldoDotacao
{
    public int IdSolicitacao { get; set; }

    public int? IdDotacao { get; set; }

    public int? IdNatDespesa { get; set; }

    public DateTime? DtSolicitacao { get; set; }

    public decimal? VlSolicitado { get; set; }

    public string? DsJustificativa { get; set; }

    public string? DsLoginSolicitacao { get; set; }

    public string? DsSituacao { get; set; }

    public string? DsParecer { get; set; }

    public string? DsLoginAnalise { get; set; }

    public DateTime? DtAnalise { get; set; }

    public virtual TbOrcDotaco? IdDotacaoNavigation { get; set; }

    public virtual TbOrcNaturezasDespesa? IdNatDespesaNavigation { get; set; }
}
