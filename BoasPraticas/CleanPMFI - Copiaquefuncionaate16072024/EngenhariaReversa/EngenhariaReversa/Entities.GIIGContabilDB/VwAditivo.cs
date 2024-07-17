using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class VwAditivo
    {
        public string? NrCnpj { get; set; }
        public int NrAditivo { get; set; }
        public DateTime? DtTermo { get; set; }
        public decimal? VlAditivo { get; set; }
        public DateTime? DtNovaTermino { get; set; }
        public string? DsMotivo { get; set; }
        public int? IdContrato { get; set; }
    }
}
