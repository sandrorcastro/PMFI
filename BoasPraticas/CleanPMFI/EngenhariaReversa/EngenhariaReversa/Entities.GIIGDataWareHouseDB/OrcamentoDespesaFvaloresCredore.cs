using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class OrcamentoDespesaFvaloresCredore
    {
        public int? IdCredor { get; set; }
        public int? IdTempo { get; set; }
        public string? CdOrgao { get; set; }
        public decimal? VlEmpenhado { get; set; }
        public decimal? VlLiquidado { get; set; }
        public decimal? VlPago { get; set; }
    }
}
