using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TempTbFinConciliacoesBancarias20032013
    {
        public int IdConciliacao { get; set; }
        public short? IdEmpresa { get; set; }
        public int? IdCc { get; set; }
        public int? NrSequencia { get; set; }
        public int? IdTipoConciliacao { get; set; }
        public DateTime? DtOperacao { get; set; }
        public string? NrDocumento { get; set; }
        public decimal? VlOperacao { get; set; }
        public string? DsOperacao { get; set; }
        public string? DsTipoOperacao { get; set; }
        public int? IdCcorigemDestino { get; set; }
        public DateTime? DtBaixa { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? IdExtrato { get; set; }
        public short? IdTipoDocFinanceiro { get; set; }
        public int? IdLancamentoDiario { get; set; }
        public int? IdConciliacaoOrigem { get; set; }
        public string? FlParcial { get; set; }
    }
}
