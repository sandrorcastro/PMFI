using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbDivTabelasEvento
    {
        public long IdEvento { get; set; }
        public long IdObjeto { get; set; }
        public string NmTabela { get; set; } = null!;
        public decimal? VlEvento { get; set; }
    }
}
