using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicDotaco
{
    public int IdLicitacao { get; set; }

    public int IdDotacao { get; set; }

    public DateTime DtVinculacao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbOrcDotaco IdDotacaoNavigation { get; set; } = null!;

    public virtual TbLicLicitaco IdLicitacaoNavigation { get; set; } = null!;
}
