using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class LicitacaoFvalore
    {
        public int? IdTempo { get; set; }
        public short? IdModalidade { get; set; }
        public string? CdOrgao { get; set; }
        public string? DsNaturezaProcedimento { get; set; }
        public string? DsSituacao { get; set; }
        public decimal? VlMaximo { get; set; }
        public decimal? VlLicitado { get; set; }
    }
}
