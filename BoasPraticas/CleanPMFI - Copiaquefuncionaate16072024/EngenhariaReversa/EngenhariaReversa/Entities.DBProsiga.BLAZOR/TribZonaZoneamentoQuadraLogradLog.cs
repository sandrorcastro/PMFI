using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribZonaZoneamentoQuadraLogradLog
    {
        public int LogId { get; set; }
        public int QuadraId { get; set; }
        public int LogradId { get; set; }
        public short ZozoId { get; set; }
        public decimal? ZoqlCaixaLogradouro { get; set; }
        public decimal? ZoqlRecuo { get; set; }
        public string? Operacao { get; set; }
        public DateTime? Data { get; set; }
        public string? Usuario { get; set; }
    }
}
