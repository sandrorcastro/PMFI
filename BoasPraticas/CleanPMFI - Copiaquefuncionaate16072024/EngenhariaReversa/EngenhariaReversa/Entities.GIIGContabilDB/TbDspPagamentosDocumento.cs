using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspPagamentosDocumento
    {
        public int IdPagamento { get; set; }
        public int IdLiquidacaoDocto { get; set; }
        public decimal? VlPagamento { get; set; }
        public decimal? VlRetencoes { get; set; }
    }
}
