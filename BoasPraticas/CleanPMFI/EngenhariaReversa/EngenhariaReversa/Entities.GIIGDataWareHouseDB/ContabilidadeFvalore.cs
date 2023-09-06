using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class ContabilidadeFvalore
    {
        public int? IdTempo { get; set; }
        public string? CdCategoria { get; set; }
        public string? CdOrigem { get; set; }
        public string? CdGrupo { get; set; }
        public string? CdDesdobramento { get; set; }
        public string? CdReceita { get; set; }
        public byte? IdTipoOperacao { get; set; }
        public decimal? VlOrcado { get; set; }
        public decimal? VlArrecadado { get; set; }
        public decimal? VlReestimativa { get; set; }
    }
}
