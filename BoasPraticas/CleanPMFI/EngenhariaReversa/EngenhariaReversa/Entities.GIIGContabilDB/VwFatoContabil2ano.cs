using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class VwFatoContabil2ano
    {
        public DateTime? DataDoPagamento { get; set; }
        public string? Cdreceita { get; set; }
        public decimal? ValorLançado { get; set; }
    }
}
