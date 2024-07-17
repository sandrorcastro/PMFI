using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinContasContabei
{
    public int IdContaContabil { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdContaContabil { get; set; }

    public string? DsContaContabil { get; set; }

    public string? DsEspecificacao { get; set; }

    public decimal? VlSaldoInicial { get; set; }

    public string? FlContaPadrao { get; set; }

    public string? DsTipoContaPadrao { get; set; }

    public string? DsCategoriaConta { get; set; }

    public DateTime? DtCadastro { get; set; }

    public DateTime? DtDesativacao { get; set; }

    public int? IdContaContabilNivelSuperior { get; set; }

    public DateTime? DtCriacao { get; set; }

    public string? DsLoginInclusao { get; set; }

    public string? DsLoginAlteracao { get; set; }

    public string? TpNaturezaSaldo { get; set; }

    public string? FlEscrituracao { get; set; }

    public string? TpNaturezaInformacao { get; set; }

    public string? TpIndicSupFinanc { get; set; }

    public string? TpControle { get; set; }

    public virtual TbFinContasContabei? IdContaContabilNivelSuperiorNavigation { get; set; }

    public virtual ICollection<TbFinContasContabei> InverseIdContaContabilNivelSuperiorNavigation { get; set; } = new List<TbFinContasContabei>();

    public virtual ICollection<TbDspDespesaExtraOrcamentarium> TbDspDespesaExtraOrcamentariumIdContaContabilCreditoNavigations { get; set; } = new List<TbDspDespesaExtraOrcamentarium>();

    public virtual ICollection<TbDspDespesaExtraOrcamentarium> TbDspDespesaExtraOrcamentariumIdContaContabilDebitoNavigations { get; set; } = new List<TbDspDespesaExtraOrcamentarium>();

    public virtual ICollection<TbFinContasContabeisContasCorrente> TbFinContasContabeisContasCorrentes { get; set; } = new List<TbFinContasContabeisContasCorrente>();

    public virtual ICollection<TbFinContasContabeisLancamentosAnalisador> TbFinContasContabeisLancamentosAnalisadors { get; set; } = new List<TbFinContasContabeisLancamentosAnalisador>();

    public virtual ICollection<TbFinContasContabeisOrgaoUnidade> TbFinContasContabeisOrgaoUnidades { get; set; } = new List<TbFinContasContabeisOrgaoUnidade>();

    public virtual ICollection<TbFinDiarioTesourarium> TbFinDiarioTesouraria { get; set; } = new List<TbFinDiarioTesourarium>();

    public virtual ICollection<TbFinLancamentosPermutaDividaFundadum> TbFinLancamentosPermutaDividaFundada { get; set; } = new List<TbFinLancamentosPermutaDividaFundadum>();

    public virtual ICollection<TbRecMovimentoReceita> TbRecMovimentoReceita { get; set; } = new List<TbRecMovimentoReceita>();

    public virtual ICollection<TbFinContaContabilEstatal> IdContaContabilEstatals { get; set; } = new List<TbFinContaContabilEstatal>();
}
