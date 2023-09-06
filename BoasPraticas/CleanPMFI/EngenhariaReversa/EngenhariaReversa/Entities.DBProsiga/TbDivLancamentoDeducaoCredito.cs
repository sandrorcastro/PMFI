using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbDivLancamentoDeducaoCredito
    {
        public TbDivLancamentoDeducaoCredito()
        {
            TbDivLancamentoDeducaoCreditoEstornos = new HashSet<TbDivLancamentoDeducaoCreditoEstorno>();
        }

        public int IdDeducao { get; set; }
        public int? IdCredito { get; set; }
        public string? TpCredito { get; set; }
        public int? NrDeducao { get; set; }
        public short? NrAnoDeducao { get; set; }
        public int? TipoTribId { get; set; }
        public short? IdTipoDeducaoCredito { get; set; }
        public int? IdLeiAto { get; set; }
        public DateTime? DtDeducao { get; set; }
        public decimal? VlDeducao { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginInclusao { get; set; }

        public virtual TbDivLancamentoCredito? IdCreditoNavigation { get; set; }
        public virtual TbDivTipoDeducaoCredito? IdTipoDeducaoCreditoNavigation { get; set; }
        public virtual ICollection<TbDivLancamentoDeducaoCreditoEstorno> TbDivLancamentoDeducaoCreditoEstornos { get; set; }
    }
}
