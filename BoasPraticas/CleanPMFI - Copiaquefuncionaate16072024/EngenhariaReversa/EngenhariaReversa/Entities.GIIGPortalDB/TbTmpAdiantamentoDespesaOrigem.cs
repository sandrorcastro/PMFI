using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpAdiantamentoDespesaOrigem
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? DataEmpenho { get; set; }
        public DateTime? DataLiquidacao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string? Justificativa { get; set; }
        public int? Matricula { get; set; }
        public string? Nome { get; set; }
        public string? NumeroEmpenho { get; set; }
        public int? NumeroLiquidacao { get; set; }
        public int? NumeroPagamento { get; set; }
        public decimal? Valor { get; set; }
    }
}
