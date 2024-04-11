using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicPesquisaCotacaoIten
{
    public int IdPesquisa { get; set; }

    public int IdLicitacao { get; set; }

    public int IdPessoa { get; set; }

    public int? NrLote { get; set; }

    public int? IdItem { get; set; }

    public decimal? VlMinimoUnitarioItem { get; set; }

    public decimal? VlMaximoUnitarioitem { get; set; }

    public virtual TbLicLicitaco IdLicitacaoNavigation { get; set; } = null!;
}
