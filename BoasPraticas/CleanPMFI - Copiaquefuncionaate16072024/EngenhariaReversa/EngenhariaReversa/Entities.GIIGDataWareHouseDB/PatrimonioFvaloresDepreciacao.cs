using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class PatrimonioFvaloresDepreciacao
    {
        public int? IdTempo { get; set; }
        public int? IdUnidade { get; set; }
        public int? IdBem { get; set; }
        public decimal? VlDepreciacao { get; set; }
    }
}
