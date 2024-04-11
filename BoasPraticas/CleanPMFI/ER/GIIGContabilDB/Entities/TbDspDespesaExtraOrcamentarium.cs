using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspDespesaExtraOrcamentarium
{
    public int IdDespesa { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public DateTime? DtDespesa { get; set; }

    public short? NrSequencia { get; set; }

    public int IdPessoa { get; set; }

    public int? IdFonte { get; set; }

    public int? IdRecurso { get; set; }

    public int? IdContaContabilDebito { get; set; }

    public int? IdContaContabilCredito { get; set; }

    public decimal? VlDespesa { get; set; }

    public string? DsHistorico { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public short? IdTipoDocFinanceiro { get; set; }

    public string? NrDocFinanceiro { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string? DsTipo { get; set; }

    public int? IdCcfavorecido { get; set; }

    public int? IdEmpenho { get; set; }

    public short? IdEmpresaOrigem { get; set; }

    public short? IdGrupo { get; set; }

    public virtual TbFinContasContabei? IdContaContabilCreditoNavigation { get; set; }

    public virtual TbFinContasContabei? IdContaContabilDebitoNavigation { get; set; }

    public virtual TbOrcFonte? IdFonteNavigation { get; set; }

    public virtual TbGerPessoa IdPessoaNavigation { get; set; } = null!;

    public virtual ICollection<TbDspDespesaExtraOrcamentariaDevReceita> TbDspDespesaExtraOrcamentariaDevReceita { get; set; } = new List<TbDspDespesaExtraOrcamentariaDevReceita>();

    public virtual ICollection<TbDspEstornosDespesaExtraOrcamentarium> TbDspEstornosDespesaExtraOrcamentaria { get; set; } = new List<TbDspEstornosDespesaExtraOrcamentarium>();

    public virtual ICollection<TbDspOrdensPagamentoDespesasExtra> TbDspOrdensPagamentoDespesasExtras { get; set; } = new List<TbDspOrdensPagamentoDespesasExtra>();

    public virtual ICollection<TbDspPagamento> TbDspPagamentos { get; set; } = new List<TbDspPagamento>();

    public virtual ICollection<TbDspConsignaco> IdConsignacaos { get; set; } = new List<TbDspConsignaco>();
}
