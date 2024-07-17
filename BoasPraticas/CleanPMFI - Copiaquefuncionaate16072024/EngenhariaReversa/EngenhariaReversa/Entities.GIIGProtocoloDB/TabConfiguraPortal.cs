using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabConfiguraPortal
    {
        public int ConfId { get; set; }
        public short? AssuId { get; set; }
        public short? UnidId { get; set; }
        public string? ConfGerarTaxa { get; set; }
        public decimal? ConfValorTaxa { get; set; }
    }
}
