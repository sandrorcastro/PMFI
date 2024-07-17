using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinContasContabeisLancamentosAnalisador
    {
        public int IdLancamentoAnalisador { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public int? NrSequencial { get; set; }
        public int IdContaContabilDebito { get; set; }
        public int IdContaContabilCredito { get; set; }
        public DateTime? DtLancamento { get; set; }
        public decimal? VlLancamento { get; set; }
        public string? DsOrigem { get; set; }
        public string? DsHistorico { get; set; }
        public string? DsObjeto { get; set; }
        public long? DsNumObjeto { get; set; }
        public string? DsSigla { get; set; }
        public short? IdTipoDocFinanceiro { get; set; }
        public string? NrDocFinanceiro { get; set; }
        public string? DsLogin { get; set; }
        public string? DsEnderecoIp { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? FlEstorno { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public int? CdEvento { get; set; }
        public int? CdHistorico { get; set; }
        public short? IdTipoOperacaoFinanceira { get; set; }
        public int? IdLancamentoEstorno { get; set; }
        public string? FlSituacao { get; set; }
        public string? DsSituacao { get; set; }

        public virtual TbFinHistoricosPadrao? CdHistoricoNavigation { get; set; }
        public virtual TbFinContasContabei IdContaContabilDebitoNavigation { get; set; } = null!;
        public virtual TbGerEmpresasGoverno? IdEmpresaNavigation { get; set; }
        public virtual TbFinTiposDocumentoFinanceiro? IdTipoDocFinanceiroNavigation { get; set; }
        public virtual TbFinTiposOperacoesFinanceira? IdTipoOperacaoFinanceiraNavigation { get; set; }
    }
}
