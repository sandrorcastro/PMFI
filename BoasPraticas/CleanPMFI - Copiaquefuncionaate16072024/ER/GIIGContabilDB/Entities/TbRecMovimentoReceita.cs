using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRecMovimentoReceita
{
    public int IdMovReceita { get; set; }

    public short? IdEmpresa { get; set; }

    public long? IdDividaFundada { get; set; }

    public DateTime? DtLancamento { get; set; }

    public decimal? VlLancado { get; set; }

    public int? IdContaContabil { get; set; }

    public int? IdRecurso { get; set; }

    public string? DsHistoricoMovimento { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public string? DsTipoOperacao { get; set; }

    public short? IdTipoDocFinanceiro { get; set; }

    public string? NrDocumento { get; set; }

    public DateTime? DtDoctoPagamento { get; set; }

    public int? IdPagamentoExtra { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public int? IdConvenio { get; set; }

    public int? IdMovReceitaEstorno { get; set; }

    public string? IdBanco { get; set; }

    public virtual TbFinContasContabei? IdContaContabilNavigation { get; set; }

    public virtual TbGerEmpresasGoverno? IdEmpresaNavigation { get; set; }

    public virtual TbCapRecurso? IdRecursoNavigation { get; set; }

    public virtual TbFinTiposDocumentoFinanceiro? IdTipoDocFinanceiroNavigation { get; set; }

    public virtual ICollection<TbRecMovimentoReceitasAporte> TbRecMovimentoReceitasAportes { get; set; } = new List<TbRecMovimentoReceitasAporte>();

    public virtual ICollection<TbRecMovimentoReceitasDetalhe> TbRecMovimentoReceitasDetalhes { get; set; } = new List<TbRecMovimentoReceitasDetalhe>();

    public virtual TbRecMovimentoReceitasRepass? TbRecMovimentoReceitasRepass { get; set; }
}
