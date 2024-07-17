using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicPublicaco
{
    public int IdPublicacao { get; set; }

    public int? IdLicitacao { get; set; }

    public short? IdVeiculoPublicacao { get; set; }

    public DateTime? DtPublicacao { get; set; }

    public string? DsPublicacao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }

    public virtual TbLicVeiculosPublicaco? IdVeiculoPublicacaoNavigation { get; set; }
}
