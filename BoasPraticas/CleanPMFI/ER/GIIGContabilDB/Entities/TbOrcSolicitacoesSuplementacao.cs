using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcSolicitacoesSuplementacao
{
    public int IdSolicitacao { get; set; }

    public int? IdEmpresa { get; set; }

    public DateTime? DtSolicitacao { get; set; }

    public decimal? VlSolicitado { get; set; }

    public string? DsJustificativa { get; set; }

    public string? DsLoginSolicitacao { get; set; }

    public string? DsSituacao { get; set; }

    public string? DsParecer { get; set; }

    public string? DsLoginAnalise { get; set; }

    public DateTime? DtAnalise { get; set; }

    public string? DsAlteracao { get; set; }

    public string? DsLoginAlteracao { get; set; }

    public string? Tpsolicitacao { get; set; }

    public virtual ICollection<TbOrcSolicitacoesSuplementacaoDotaco> TbOrcSolicitacoesSuplementacaoDotacos { get; set; } = new List<TbOrcSolicitacoesSuplementacaoDotaco>();
}
