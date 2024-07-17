using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class FinanceiroFvaloresLiquidacao
    {
        public int? IdTempo { get; set; }
        public string? CdFonte { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public decimal? VlLiquidadoPendente { get; set; }
    }
}
