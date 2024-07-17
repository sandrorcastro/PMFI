using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class OrcamentoDespesaFvalore
    {
        public int? IdTempo { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? CdFuncao { get; set; }
        public string? CdSubFuncao { get; set; }
        public string? CdPrograma { get; set; }
        public string? CdProjetoAtividade { get; set; }
        public string? CdNaturezaDespesa { get; set; }
        public string? CdFonte { get; set; }
        public decimal? VlOrcado { get; set; }
        public decimal? VlExecutado { get; set; }
        public decimal? VlLiquidado { get; set; }
        public decimal? VlPago { get; set; }
    }
}
