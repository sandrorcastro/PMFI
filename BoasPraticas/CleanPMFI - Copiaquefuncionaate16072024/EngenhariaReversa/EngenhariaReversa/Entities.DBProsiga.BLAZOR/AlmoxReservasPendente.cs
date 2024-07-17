using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AlmoxReservasPendente
    {
        public long AlmoxId { get; set; }
        public long ItemId { get; set; }
        public decimal? QtdeEntrada { get; set; }
        public decimal? QtdeSaida { get; set; }
        public decimal? QtdeReservada { get; set; }
        public decimal? EstoqueMin { get; set; }
        public decimal? EstoqueMax { get; set; }
    }
}
