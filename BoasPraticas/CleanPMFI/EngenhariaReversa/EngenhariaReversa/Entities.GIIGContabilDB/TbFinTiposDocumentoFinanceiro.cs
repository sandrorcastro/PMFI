using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinTiposDocumentoFinanceiro
    {
        public TbFinTiposDocumentoFinanceiro()
        {
            TbDspOrdensPagamentos = new HashSet<TbDspOrdensPagamento>();
            TbDspPagamentos = new HashSet<TbDspPagamento>();
            TbFinConciliacoesBancaria = new HashSet<TbFinConciliacoesBancaria>();
            TbFinContasContabeisLancamentosAnalisadors = new HashSet<TbFinContasContabeisLancamentosAnalisador>();
            TbRecMovimentoReceita = new HashSet<TbRecMovimentoReceita>();
            IdTipoOperacaoFinanceiras = new HashSet<TbFinTiposOperacoesFinanceira>();
        }

        public short IdTipoDocFinanceiro { get; set; }
        public string? NmTipoDocFinanceiro { get; set; }
        public short? CdTipoTc { get; set; }
        public bool? FlAtivo { get; set; }
        public string? FlEntradaSaida { get; set; }

        public virtual ICollection<TbDspOrdensPagamento> TbDspOrdensPagamentos { get; set; }
        public virtual ICollection<TbDspPagamento> TbDspPagamentos { get; set; }
        public virtual ICollection<TbFinConciliacoesBancaria> TbFinConciliacoesBancaria { get; set; }
        public virtual ICollection<TbFinContasContabeisLancamentosAnalisador> TbFinContasContabeisLancamentosAnalisadors { get; set; }
        public virtual ICollection<TbRecMovimentoReceita> TbRecMovimentoReceita { get; set; }

        public virtual ICollection<TbFinTiposOperacoesFinanceira> IdTipoOperacaoFinanceiras { get; set; }
    }
}
