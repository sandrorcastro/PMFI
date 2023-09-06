using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRecRegrasDiarioArrecadacaoReceita
    {
        public int IdConfig { get; set; }
        public int? IdRegra { get; set; }
        public string? CdReceita { get; set; }
    }
}
