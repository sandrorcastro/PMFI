using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspDespesaExtraOrcamentarium
    {
        public TbDspDespesaExtraOrcamentarium()
        {
            TbDspDespesaExtraOrcamentariaDevReceita = new HashSet<TbDspDespesaExtraOrcamentariaDevReceita>();
            TbDspEstornosDespesaExtraOrcamentaria = new HashSet<TbDspEstornosDespesaExtraOrcamentarium>();
            TbDspOrdensPagamentoDespesasExtras = new HashSet<TbDspOrdensPagamentoDespesasExtra>();
            TbDspPagamentos = new HashSet<TbDspPagamento>();
            IdConsignacaos = new HashSet<TbDspConsignaco>();
        }

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
        public virtual ICollection<TbDspDespesaExtraOrcamentariaDevReceita> TbDspDespesaExtraOrcamentariaDevReceita { get; set; }
        public virtual ICollection<TbDspEstornosDespesaExtraOrcamentarium> TbDspEstornosDespesaExtraOrcamentaria { get; set; }
        public virtual ICollection<TbDspOrdensPagamentoDespesasExtra> TbDspOrdensPagamentoDespesasExtras { get; set; }
        public virtual ICollection<TbDspPagamento> TbDspPagamentos { get; set; }

        public virtual ICollection<TbDspConsignaco> IdConsignacaos { get; set; }
    }
}
