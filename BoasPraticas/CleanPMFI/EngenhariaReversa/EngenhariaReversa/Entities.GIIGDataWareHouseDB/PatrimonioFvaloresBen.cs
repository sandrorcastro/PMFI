using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class PatrimonioFvaloresBen
    {
        public int? IdTempo { get; set; }
        public int? IdUnidade { get; set; }
        public int? IdBem { get; set; }
        public decimal? VlEntrada { get; set; }
        public decimal? VlAtualizado { get; set; }
    }
}
