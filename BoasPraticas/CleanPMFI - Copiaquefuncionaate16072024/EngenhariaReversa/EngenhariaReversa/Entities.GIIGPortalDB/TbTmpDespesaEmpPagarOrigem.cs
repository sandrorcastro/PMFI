using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpDespesaEmpPagarOrigem
    {
        public int IdDespesaEmpPagar { get; set; }
        public short? Ano { get; set; }
        public string? CdFonte { get; set; }
        public string? Fonte { get; set; }
        public short? Mes { get; set; }
        public decimal? SaldoPagar { get; set; }
    }
}
