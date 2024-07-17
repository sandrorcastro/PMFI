using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbDivLancamentoDeducaoCredito
    {
        public TbDivLancamentoDeducaoCredito()
        {
            TbDivLancamentoDeducaoCreditoEstornos = new HashSet<TbDivLancamentoDeducaoCreditoEstorno>();
        }

        public int IdDeducao { get; set; }
        public int? IdLcto { get; set; }
        public int? NrDeducao { get; set; }
        public short? NrAnoDeducao { get; set; }
        public short? IdTpDeducaoCredito { get; set; }
        public int? IdLeiAto { get; set; }
        public DateTime? DtDeducao { get; set; }
        public decimal? VlDeducao { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginInclusao { get; set; }

        public virtual TbDivLancamentoCredito? IdLctoNavigation { get; set; }
        public virtual TbGerLeiAto? IdLeiAtoNavigation { get; set; }
        public virtual TbGerTipoDeducaoCredito? IdTpDeducaoCreditoNavigation { get; set; }
        public virtual ICollection<TbDivLancamentoDeducaoCreditoEstorno> TbDivLancamentoDeducaoCreditoEstornos { get; set; }
    }
}
