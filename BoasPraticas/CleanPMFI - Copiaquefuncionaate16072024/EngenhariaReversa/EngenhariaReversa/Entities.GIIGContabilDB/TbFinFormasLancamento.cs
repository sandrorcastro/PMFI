using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinFormasLancamento
    {
        public int IdFormaLancamento { get; set; }
        public string? CdFormaLancamento { get; set; }
        public string? DsFormaLancamento { get; set; }
        public bool? FlusaRemessa { get; set; }
    }
}
