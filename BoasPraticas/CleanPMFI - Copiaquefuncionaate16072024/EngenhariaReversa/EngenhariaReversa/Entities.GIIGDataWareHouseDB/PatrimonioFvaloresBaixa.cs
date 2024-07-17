using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class PatrimonioFvaloresBaixa
    {
        public int? IdTempo { get; set; }
        public int? IdUnidade { get; set; }
        public int? IdBem { get; set; }
        public decimal? VlBaixado { get; set; }
    }
}
