using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class FinanceiroFvaloresPagamento
    {
        public int? IdTempo { get; set; }
        public int? IdConta { get; set; }
        public string? CdFonte { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public decimal? VlPagamento { get; set; }
    }
}
