using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspAquisicaoBen
    {
        public int IdAquisicao { get; set; }
        public DateTime? DtAquisicao { get; set; }
        public string? DsAquisicao { get; set; }
        public string? DsLogin { get; set; }
    }
}
