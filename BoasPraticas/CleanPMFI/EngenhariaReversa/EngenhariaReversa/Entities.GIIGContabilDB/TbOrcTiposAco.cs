using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcTiposAco
    {
        public short IdTipoAcao { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string? DsTipoAcao { get; set; }
        public short? NrNivel { get; set; }
        public bool? FlVinculaNatureza { get; set; }
    }
}
