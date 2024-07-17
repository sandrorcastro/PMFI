using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSycSincronismo
    {
        public int IdSincronismo { get; set; }
        public string? DsSigla { get; set; }
        public string? DsXmlfiltro { get; set; }
        public string? DsDeleteCommand { get; set; }
        public DateTime? DtSincronia { get; set; }
        public string? DsResultado { get; set; }
    }
}
