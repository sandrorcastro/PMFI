using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribLeisDescParcela
    {
        public long LeiDescId { get; set; }
        public short NrParcelas { get; set; }
        public decimal? VlPercPrincipal { get; set; }
        public decimal? VlPercJuros { get; set; }
        public decimal? VlPercMulta { get; set; }
        public decimal? VlPercCorrecao { get; set; }
        public decimal? VlPercMultaDa { get; set; }
        public decimal? VlMinimoParcelar { get; set; }
        public decimal? VlMinimoParcela { get; set; }
    }
}
