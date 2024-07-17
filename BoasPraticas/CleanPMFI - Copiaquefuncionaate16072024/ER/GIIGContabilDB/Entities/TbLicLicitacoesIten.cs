using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicLicitacoesIten
{
    public int IdLicitacaoItem { get; set; }

    public int? IdLicitacao { get; set; }

    public int? IdRms { get; set; }

    public int? IdItem { get; set; }

    public decimal? NrQuantidade { get; set; }

    public decimal? VlUnitarioMaximo { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public int? IdRegistro { get; set; }

    public short? IdCondicaoPgto { get; set; }

    public short? NrPrazoLimiteEntrega { get; set; }

    public string? TpEntrega { get; set; }

    public int? IdLicitacaoItemOrigem { get; set; }

    public virtual TbGerCondicoesPagamento? IdCondicaoPgtoNavigation { get; set; }

    public virtual TbDspIten? IdItemNavigation { get; set; }

    public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }

    public virtual ICollection<TbLicLicitacoesItensLote> TbLicLicitacoesItensLotes { get; set; } = new List<TbLicLicitacoesItensLote>();
}
