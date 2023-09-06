using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpApoioCargaPti2
    {
        public int? IdApoio { get; set; }
        public string? Agencia { get; set; }
        public string? Banco { get; set; }
        public string? Conta { get; set; }
        public decimal? SaldoContabil { get; set; }
        public decimal? SaldoExtrato { get; set; }
    }
}
