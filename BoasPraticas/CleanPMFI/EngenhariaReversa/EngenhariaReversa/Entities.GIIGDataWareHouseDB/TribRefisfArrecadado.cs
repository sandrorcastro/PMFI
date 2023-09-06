using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribRefisfArrecadado
    {
        public int? IdLei { get; set; }
        public string? DsTipoCadastro { get; set; }
        public decimal? VlPago { get; set; }
        public decimal? VlPrincipal { get; set; }
        public decimal? VlCorrecao { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlJuros { get; set; }
        public decimal? VlMulta { get; set; }
        public decimal? VlMultaDa { get; set; }
    }
}
