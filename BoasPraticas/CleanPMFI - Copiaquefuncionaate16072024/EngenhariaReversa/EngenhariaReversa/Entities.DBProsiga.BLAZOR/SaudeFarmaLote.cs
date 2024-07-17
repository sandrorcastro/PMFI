using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeFarmaLote
    {
        public int IdEstoque { get; set; }
        public string IdentLote { get; set; } = null!;
        public int IdFabricante { get; set; }
        public int IdMedicamento { get; set; }
        public decimal? SaldoLoteEstoque { get; set; }
    }
}
