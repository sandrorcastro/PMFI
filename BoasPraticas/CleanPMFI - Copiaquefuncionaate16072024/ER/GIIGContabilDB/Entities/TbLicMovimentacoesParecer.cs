using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicMovimentacoesParecer
{
    public int IdMovParecer { get; set; }

    public int? IdLicitacao { get; set; }

    public short? IdParecer { get; set; }

    public int? IdPessoa { get; set; }

    public DateTime? DtParecer { get; set; }

    public string? DsParecer { get; set; }

    public string? FlParecerFavoravel { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public short? NrSequencial { get; set; }

    public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }

    public virtual TbLicParecere? IdParecerNavigation { get; set; }
}
