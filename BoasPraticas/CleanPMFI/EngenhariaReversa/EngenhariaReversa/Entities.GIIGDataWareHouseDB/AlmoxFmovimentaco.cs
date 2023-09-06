using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class AlmoxFmovimentaco
    {
        public int? IdItem { get; set; }
        public int? IdTempo { get; set; }
        public int? IdUnidade { get; set; }
        public int? IdServidor { get; set; }
        public int? IdFornecedor { get; set; }
        public decimal? NrQtdeEntrada { get; set; }
        public decimal? NrQtdeSaida { get; set; }
        public string? TpOrigem { get; set; }
    }
}
