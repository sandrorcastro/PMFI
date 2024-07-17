using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class OrcamentoReceitaFvalore
    {
        public int? IdTempo { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? CdFonte { get; set; }
        public string? CdReceita { get; set; }
        public decimal? VlOrcado { get; set; }
        public decimal? VlArrecadado { get; set; }
    }
}
