using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class VwFatArrecadacao2ano
    {
        public string? Receita { get; set; }
        public short? Ano { get; set; }
        public string? Tipo { get; set; }
        public decimal? ValorAcumulado { get; set; }
    }
}
