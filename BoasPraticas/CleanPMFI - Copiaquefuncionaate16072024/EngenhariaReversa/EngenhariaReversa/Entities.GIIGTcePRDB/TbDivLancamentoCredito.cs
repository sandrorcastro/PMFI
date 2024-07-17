using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbDivLancamentoCredito
    {
        public TbDivLancamentoCredito()
        {
            TbDivDiarioArrecadacaos = new HashSet<TbDivDiarioArrecadacao>();
            TbDivLancamentoAtualizacaoMonetariaCreditos = new HashSet<TbDivLancamentoAtualizacaoMonetariaCredito>();
            TbDivLancamentoCreditoComposicaos = new HashSet<TbDivLancamentoCreditoComposicao>();
            TbDivLancamentoCreditoEstornos = new HashSet<TbDivLancamentoCreditoEstorno>();
            TbDivLancamentoDeducaoCreditos = new HashSet<TbDivLancamentoDeducaoCredito>();
        }

        public int IdLancamento { get; set; }
        public short? IdPessoa { get; set; }
        public int? NrCredito { get; set; }
        public short? NrAnoCredito { get; set; }
        public short? IdTpNatCredito { get; set; }
        public short? IdTpCredito { get; set; }
        public short? IdTpOpCredito { get; set; }
        public DateTime? DlLcto { get; set; }
        public short? NrMesBase { get; set; }
        public short? NrAnoBase { get; set; }
        public int? IdLeiAto { get; set; }
        public string? TpDocContribuinte { get; set; }
        public string? NrDocContribuinte { get; set; }
        public decimal? VlCredito { get; set; }
        public string? CdReceita { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginInclusao { get; set; }

        public virtual TbGerLeiAto? IdLeiAtoNavigation { get; set; }
        public virtual TbGerTipoNaturezaCredito? IdTpNatCreditoNavigation { get; set; }
        public virtual TbGerTipoOperacaoCredito? IdTpOpCreditoNavigation { get; set; }
        public virtual ICollection<TbDivDiarioArrecadacao> TbDivDiarioArrecadacaos { get; set; }
        public virtual ICollection<TbDivLancamentoAtualizacaoMonetariaCredito> TbDivLancamentoAtualizacaoMonetariaCreditos { get; set; }
        public virtual ICollection<TbDivLancamentoCreditoComposicao> TbDivLancamentoCreditoComposicaos { get; set; }
        public virtual ICollection<TbDivLancamentoCreditoEstorno> TbDivLancamentoCreditoEstornos { get; set; }
        public virtual ICollection<TbDivLancamentoDeducaoCredito> TbDivLancamentoDeducaoCreditos { get; set; }
    }
}
