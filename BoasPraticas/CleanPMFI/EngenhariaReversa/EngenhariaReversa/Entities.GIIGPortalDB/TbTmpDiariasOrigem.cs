using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpDiariasOrigem
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? NmRazaoSocial { get; set; }
        public string? NmPessoa { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public decimal? NrDiarias { get; set; }
        public string? DsDestino { get; set; }
        public string? DsObjetivo { get; set; }
        public decimal? VlUnitario { get; set; }
        public decimal? VlTotal { get; set; }
        public string? DsTipoLocomocao { get; set; }
        public decimal? VlTotalPassagem { get; set; }
        public short? NrEmpenho { get; set; }
        public short? NrAnoEmpenho { get; set; }
        public int? NumeroLiquidacao { get; set; }
        public int? NumeroPagamento { get; set; }
        public DateTime? DtEmpenho { get; set; }
        public DateTime? DataLiquidacao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public int? Matricula { get; set; }
    }
}
