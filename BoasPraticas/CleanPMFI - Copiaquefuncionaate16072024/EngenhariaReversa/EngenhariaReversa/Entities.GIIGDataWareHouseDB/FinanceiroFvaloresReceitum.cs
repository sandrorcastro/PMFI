using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class FinanceiroFvaloresReceitum
    {
        public int? IdTempo { get; set; }
        public int? IdConta { get; set; }
        public string? CdFonte { get; set; }
        public string? CdReceita { get; set; }
        public decimal? VlReceita { get; set; }
    }
}
