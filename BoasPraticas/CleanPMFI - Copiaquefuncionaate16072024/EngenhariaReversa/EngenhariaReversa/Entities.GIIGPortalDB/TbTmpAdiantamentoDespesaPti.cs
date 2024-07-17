using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpAdiantamentoDespesaPti
    {
        public int? Id { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? DataEmpenho { get; set; }
        public DateTime? DataLiquidacao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string? Justificativa { get; set; }
        public string? Matricula { get; set; }
        public string? Nome { get; set; }
        public string? NumeroEmpenho { get; set; }
        public string? NumeroLiquidacao { get; set; }
        public string? NumeroPagamento { get; set; }
        public string? Valor { get; set; }
    }
}
