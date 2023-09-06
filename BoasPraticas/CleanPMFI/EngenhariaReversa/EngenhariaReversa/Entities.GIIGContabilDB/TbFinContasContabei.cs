using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinContasContabei
    {
        public TbFinContasContabei()
        {
            InverseIdContaContabilNivelSuperiorNavigation = new HashSet<TbFinContasContabei>();
            TbDspDespesaExtraOrcamentariumIdContaContabilCreditoNavigations = new HashSet<TbDspDespesaExtraOrcamentarium>();
            TbDspDespesaExtraOrcamentariumIdContaContabilDebitoNavigations = new HashSet<TbDspDespesaExtraOrcamentarium>();
            TbFinContasContabeisContasCorrentes = new HashSet<TbFinContasContabeisContasCorrente>();
            TbFinContasContabeisLancamentosAnalisadors = new HashSet<TbFinContasContabeisLancamentosAnalisador>();
            TbFinContasContabeisOrgaoUnidades = new HashSet<TbFinContasContabeisOrgaoUnidade>();
            TbFinDiarioTesouraria = new HashSet<TbFinDiarioTesourarium>();
            TbFinLancamentosPermutaDividaFundada = new HashSet<TbFinLancamentosPermutaDividaFundadum>();
            TbRecMovimentoReceita = new HashSet<TbRecMovimentoReceita>();
            IdContaContabilEstatals = new HashSet<TbFinContaContabilEstatal>();
        }

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
        public virtual ICollection<TbFinContasContabei> InverseIdContaContabilNivelSuperiorNavigation { get; set; }
        public virtual ICollection<TbDspDespesaExtraOrcamentarium> TbDspDespesaExtraOrcamentariumIdContaContabilCreditoNavigations { get; set; }
        public virtual ICollection<TbDspDespesaExtraOrcamentarium> TbDspDespesaExtraOrcamentariumIdContaContabilDebitoNavigations { get; set; }
        public virtual ICollection<TbFinContasContabeisContasCorrente> TbFinContasContabeisContasCorrentes { get; set; }
        public virtual ICollection<TbFinContasContabeisLancamentosAnalisador> TbFinContasContabeisLancamentosAnalisadors { get; set; }
        public virtual ICollection<TbFinContasContabeisOrgaoUnidade> TbFinContasContabeisOrgaoUnidades { get; set; }
        public virtual ICollection<TbFinDiarioTesourarium> TbFinDiarioTesouraria { get; set; }
        public virtual ICollection<TbFinLancamentosPermutaDividaFundadum> TbFinLancamentosPermutaDividaFundada { get; set; }
        public virtual ICollection<TbRecMovimentoReceita> TbRecMovimentoReceita { get; set; }

        public virtual ICollection<TbFinContaContabilEstatal> IdContaContabilEstatals { get; set; }
    }
}
