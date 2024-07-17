using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpDespesaLiquidadaOrigem
    {
        public int IdDespesaLiquidada { get; set; }
        public short? Ano { get; set; }
        public short? Mes { get; set; }
        public decimal? ValorEstornadoOrcamento { get; set; }
        public decimal? ValorEstornadoPagar { get; set; }
        public decimal? ValorLiquidadoOrcamento { get; set; }
        public decimal? ValorLiquidadoPagar { get; set; }
        public decimal? ValorLiquido { get; set; }
    }
}
