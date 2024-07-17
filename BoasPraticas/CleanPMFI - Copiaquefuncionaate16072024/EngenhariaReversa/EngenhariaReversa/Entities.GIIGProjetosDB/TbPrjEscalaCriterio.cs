using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbPrjEscalaCriterio
    {
        public int IdEscalaCriterio { get; set; }
        public int IdCriterioLinha { get; set; }
        public int? IdCriterioColuna { get; set; }
        public int? IdEscala { get; set; }
        public decimal? VlValor { get; set; }

        public virtual TbPrjCriterio? IdCriterioColunaNavigation { get; set; }
        public virtual TbPrjCriterio IdCriterioLinhaNavigation { get; set; } = null!;
    }
}
