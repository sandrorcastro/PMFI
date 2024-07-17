using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbDivLancamentoCreditoComposicao
    {
        public int IdLctoComposicao { get; set; }
        public int? IdLancamento { get; set; }
        public int? IdDivImovel { get; set; }
        public int? IdDivEmpresa { get; set; }
        public int? IdDivContribuinte { get; set; }
        public decimal? VlComposicao { get; set; }
        public decimal? IdTributo { get; set; }
        public int? IdDeducao { get; set; }
        public int? IdEstono { get; set; }
        public bool? FlUnica { get; set; }

        public virtual TbDivLancamentoCredito? IdLancamentoNavigation { get; set; }
    }
}
