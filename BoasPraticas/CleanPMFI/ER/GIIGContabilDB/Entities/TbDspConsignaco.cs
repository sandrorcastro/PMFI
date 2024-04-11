using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspConsignaco
{
    public int IdConsignacao { get; set; }

    public short? NrSequencia { get; set; }

    public int? IdLiquidacao { get; set; }

    public DateTime? DtConsignacao { get; set; }

    public int? IdPessoa { get; set; }

    public string? NrCei { get; set; }

    public decimal? VlConsignacao { get; set; }

    public int? IdContaContabil { get; set; }

    public int? IdContaContabilInscricao { get; set; }

    public string? DsHistorico { get; set; }

    public decimal? NrPercentual { get; set; }

    public int? IdRecurso { get; set; }

    public short? IdTipoConsignacao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public string? FlExcluido { get; set; }

    public DateTime? DtExclusao { get; set; }

    public int? IdLiquidacaoDocto { get; set; }

    public short? IdTipoDocFinanceiro { get; set; }

    public string? NrDocumento { get; set; }

    public int? IdCcorigem { get; set; }

    public virtual TbDspLiquidaco? IdLiquidacaoNavigation { get; set; }

    public virtual TbCapRecurso? IdRecursoNavigation { get; set; }

    public virtual TbDspTiposConsignaco? IdTipoConsignacaoNavigation { get; set; }

    public virtual ICollection<TbDspConsignacoesIten> TbDspConsignacoesItens { get; set; } = new List<TbDspConsignacoesIten>();

    public virtual ICollection<TbDspGp> TbDspGps { get; set; } = new List<TbDspGp>();

    public virtual ICollection<TbDspLiquidacoesDoctosIntegrado> TbDspLiquidacoesDoctosIntegrados { get; set; } = new List<TbDspLiquidacoesDoctosIntegrado>();

    public virtual ICollection<TbDspPagamento> TbDspPagamentos { get; set; } = new List<TbDspPagamento>();

    public virtual ICollection<TbDspDespesaExtraOrcamentarium> IdDespesas { get; set; } = new List<TbDspDespesaExtraOrcamentarium>();
}
