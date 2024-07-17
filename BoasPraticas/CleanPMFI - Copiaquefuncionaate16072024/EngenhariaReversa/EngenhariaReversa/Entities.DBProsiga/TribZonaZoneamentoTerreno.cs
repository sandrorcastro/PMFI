using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribZonaZoneamentoTerreno
    {
        public long TerrenoId { get; set; }
        public short ZozoId { get; set; }
        public decimal? ZotrCaixaLogradouro { get; set; }
        public decimal? ZotrRecuo { get; set; }
    }
}
