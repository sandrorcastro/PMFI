using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbDivLancamentoAtualizacaoMonetariaCredito
    {
        public TbDivLancamentoAtualizacaoMonetariaCredito()
        {
            TbDivLancamentoAtualizacaoCreditoEstornos = new HashSet<TbDivLancamentoAtualizacaoCreditoEstorno>();
        }

        public int IdAtualizacao { get; set; }
        public int? IdLcto { get; set; }
        public int? NrAtualizacao { get; set; }
        public short? NrAnoAtualizacao { get; set; }
        public int? IdLeiAto { get; set; }
        public short? IdTpAtualizacaoCredito { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public decimal? VlAtualizacao { get; set; }
        public int IdLctoComposicao { get; set; }

        public virtual TbDivLancamentoCredito? IdLctoNavigation { get; set; }
        public virtual TbGerLeiAto? IdLeiAtoNavigation { get; set; }
        public virtual TbGerTipoAtualizacaoCredito? IdTpAtualizacaoCreditoNavigation { get; set; }
        public virtual ICollection<TbDivLancamentoAtualizacaoCreditoEstorno> TbDivLancamentoAtualizacaoCreditoEstornos { get; set; }
    }
}
