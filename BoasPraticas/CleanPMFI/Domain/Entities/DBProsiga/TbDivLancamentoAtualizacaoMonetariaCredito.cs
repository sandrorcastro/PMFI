using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbDivLancamentoAtualizacaoMonetariaCredito
    {
        public TbDivLancamentoAtualizacaoMonetariaCredito()
        {
            TbDivLancamentoAtualizacaoCreditoEstornos = new HashSet<TbDivLancamentoAtualizacaoCreditoEstorno>();
        }

        public int IdAtualizacao { get; set; }
        public int? IdCredito { get; set; }
        public string? TpCredito { get; set; }
        public int? NrAtualizacao { get; set; }
        public short? NrAnoAtualizacao { get; set; }
        public int? IdLeiAto { get; set; }
        public short? IdTipoAtualizacaoCredito { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public decimal? VlAtualizacao { get; set; }
        public int? IdArrecadacao { get; set; }

        public virtual TbDivLancamentoCredito? IdCreditoNavigation { get; set; }
        public virtual ICollection<TbDivLancamentoAtualizacaoCreditoEstorno> TbDivLancamentoAtualizacaoCreditoEstornos { get; set; }
    }
}
