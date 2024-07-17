using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcArtigosExclusaoCreditoAdicional
    {
        public int IdArtigoExclusao { get; set; }
        public int? IdEmpresa { get; set; }
        public short? NrLei { get; set; }
        public short? NrAnoLei { get; set; }
        public string? NrArtigo { get; set; }
        public string? DsArtigo { get; set; }
        public decimal? VlPercentual { get; set; }
    }
}
