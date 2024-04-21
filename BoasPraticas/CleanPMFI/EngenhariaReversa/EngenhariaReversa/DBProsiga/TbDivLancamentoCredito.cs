using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbDivLancamentoCredito
    {
        public TbDivLancamentoCredito()
        {
            TbDivDividaAtivaJudicials = new HashSet<TbDivDividaAtivaJudicial>();
            TbDivInscricaoSancaos = new HashSet<TbDivInscricaoSancao>();
            TbDivLancamentoAtualizacaoMonetariaCreditos = new HashSet<TbDivLancamentoAtualizacaoMonetariaCredito>();
            TbDivLancamentoCreditoComposicaos = new HashSet<TbDivLancamentoCreditoComposicao>();
            TbDivLancamentoCreditoEstornos = new HashSet<TbDivLancamentoCreditoEstorno>();
            TbDivLancamentoDeducaoCreditos = new HashSet<TbDivLancamentoDeducaoCredito>();
            TbDivParcelamentoCreditos = new HashSet<TbDivParcelamentoCredito>();
        }

        public int IdCredito { get; set; }
        public string? TpCredito { get; set; }
        public int? NrCredito { get; set; }
        public short? NrAnoCredito { get; set; }
        public short? IdTipoCredito { get; set; }
        public short? IdTipoOperacaoCredito { get; set; }
        public int? TipoTribId { get; set; }
        public DateTime? DtLancamento { get; set; }
        public short? NrMesBase { get; set; }
        public short? NrAnoBase { get; set; }
        public short? NrAnoInscricao { get; set; }
        public int? IdLeiAto { get; set; }
        public string? TpDocContribuinte { get; set; }
        public string? NrDocContribuinte { get; set; }
        public string? NmContribuinte { get; set; }
        public decimal? VlCredito { get; set; }
        public string? CdReceita { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginInclusao { get; set; }
        public int? IdCreditoOrigem { get; set; }
        public short? TpCadastro { get; set; }
        public long? IdCadastro { get; set; }
        public DateTime? DtUltimaCorrecao { get; set; }
        public short? IdTipoOperacaoReceita { get; set; }

        public virtual ICollection<TbDivDividaAtivaJudicial> TbDivDividaAtivaJudicials { get; set; }
        public virtual ICollection<TbDivInscricaoSancao> TbDivInscricaoSancaos { get; set; }
        public virtual ICollection<TbDivLancamentoAtualizacaoMonetariaCredito> TbDivLancamentoAtualizacaoMonetariaCreditos { get; set; }
        public virtual ICollection<TbDivLancamentoCreditoComposicao> TbDivLancamentoCreditoComposicaos { get; set; }
        public virtual ICollection<TbDivLancamentoCreditoEstorno> TbDivLancamentoCreditoEstornos { get; set; }
        public virtual ICollection<TbDivLancamentoDeducaoCredito> TbDivLancamentoDeducaoCreditos { get; set; }
        public virtual ICollection<TbDivParcelamentoCredito> TbDivParcelamentoCreditos { get; set; }
    }
}
