using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbTcmPainelConferenciaDespesa
    {
        public int IdConferencia { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public short? NrAno { get; set; }
        public string? DsPeriodo { get; set; }
        public decimal? VlEmpenhadoDdr { get; set; }
        public decimal? VlLiquidarDdr { get; set; }
        public decimal? VlPagoDdr { get; set; }
        public decimal? VlPagarDdr { get; set; }
        public decimal? VlCreditoUtilizado { get; set; }
        public decimal? VlCreditoLiquidar { get; set; }
        public decimal? VlCreditoLiquidadoPagar { get; set; }
        public decimal? VlCreditoLiquidadoPago { get; set; }
    }
}
