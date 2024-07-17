using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCtcRateioCriterio
    {
        public int IdRateio { get; set; }
        public int IdCentroCusto { get; set; }
        public int IdCriterio { get; set; }
        public decimal? VlRateio { get; set; }
        public decimal? VlCoeficiente { get; set; }
    }
}
