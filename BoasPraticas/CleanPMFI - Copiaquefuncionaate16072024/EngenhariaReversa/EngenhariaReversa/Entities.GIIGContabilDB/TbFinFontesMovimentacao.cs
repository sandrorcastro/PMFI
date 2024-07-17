using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinFontesMovimentacao
    {
        public int IdMovimento { get; set; }
        public DateTime? DtMovimento { get; set; }
        public int? IdFonte { get; set; }
        public string? DsTipo { get; set; }
        public decimal? VlMovimento { get; set; }
        public string? DsHistorico { get; set; }
        public string? DsObjeto { get; set; }
        public int? IdObjeto { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
    }
}
