using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpReceitasOrigem
    {
        public short? IdEmpresaOrc { get; set; }
        public short? AnoArrec { get; set; }
        public short? NrMes { get; set; }
        public int? IdReceita { get; set; }
        public decimal? VlOrcado { get; set; }
        public decimal? VlCorrigido { get; set; }
        public decimal? Acumulado { get; set; }
        public int? IdReceitaNivelSuper { get; set; }
        public string? Tipo { get; set; }
    }
}
