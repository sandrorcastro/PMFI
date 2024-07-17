using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FissCruzamentoMaster
    {
        public short Id { get; set; }
        public string Session { get; set; } = null!;
        public string? Nome { get; set; }
        public int? Total { get; set; }
    }
}
