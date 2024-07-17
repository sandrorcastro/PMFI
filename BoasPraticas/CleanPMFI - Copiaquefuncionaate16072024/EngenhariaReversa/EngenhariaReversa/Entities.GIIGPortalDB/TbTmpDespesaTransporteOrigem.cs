using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpDespesaTransporteOrigem
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? DataEmpenho { get; set; }
        public DateTime? DataLiquidacao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string? Destino { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? MotivoViagem { get; set; }
        public string? NomeBeneficiario { get; set; }
        public string? NomeCredor { get; set; }
        public string? NumeroEmpenho { get; set; }
        public int? NumeroLiquidacao { get; set; }
        public int? NumeroPagamento { get; set; }
        public string? Orgao { get; set; }
        public string? TipoGasto { get; set; }
        public decimal? ValorGasto { get; set; }
    }
}
