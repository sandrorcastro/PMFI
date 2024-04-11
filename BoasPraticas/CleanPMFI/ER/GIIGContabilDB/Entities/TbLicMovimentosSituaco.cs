using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicMovimentosSituaco
{
    public int IdMovLicitacao { get; set; }

    public int IdLicitacao { get; set; }

    public short IdSituacao { get; set; }

    public DateTime? DtMovimento { get; set; }

    public string? DsMotivacao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public int? IdLeiAto { get; set; }

    public int? IdPessoa { get; set; }

    public DateTime? DtBaseTce { get; set; }

    public virtual TbLicLicitaco IdLicitacaoNavigation { get; set; } = null!;

    public virtual TbLicSituaco IdSituacaoNavigation { get; set; } = null!;
}
