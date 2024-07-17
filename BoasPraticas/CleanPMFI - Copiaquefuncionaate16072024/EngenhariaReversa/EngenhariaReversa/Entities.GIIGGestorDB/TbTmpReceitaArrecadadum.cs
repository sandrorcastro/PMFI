using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGGestorDB
{
    public partial class TbTmpReceitaArrecadadum
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtExecucao { get; set; }
        public int? Idreceita { get; set; }
        public int? Idreceitanivelsuper { get; set; }
        public string? Cdreceita { get; set; }
        public string? Dsreceita { get; set; }
        public decimal? Vlorcado { get; set; }
        public decimal? Vlarrecadado { get; set; }
    }
}
