using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpDespesaPaga
    {
        public int IdDespesaPagas { get; set; }
        public short? Ano { get; set; }
        public short? Mes { get; set; }
        public decimal? ValorEstornadoOrcamento { get; set; }
        public decimal? ValorEstornadoPagar { get; set; }
        public decimal? ValorLiquido { get; set; }
        public decimal? ValorPagoOrcamento { get; set; }
        public decimal? ValorPagoPagar { get; set; }
    }
}
