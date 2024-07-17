using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCtcLiquidacaoCentroCusto
    {
        public int IdLiquidacao { get; set; }
        public int IdCentroCusto { get; set; }
        public decimal? VlPercRateio { get; set; }
        public short? IdEmpresa { get; set; }
        public int NrNumObjeto { get; set; }
        public decimal? VlLiquidacao { get; set; }
        public DateTime? DtLiquidacao { get; set; }
        public decimal? VlLancamento { get; set; }
        public string? TpOrigem { get; set; }
    }
}
