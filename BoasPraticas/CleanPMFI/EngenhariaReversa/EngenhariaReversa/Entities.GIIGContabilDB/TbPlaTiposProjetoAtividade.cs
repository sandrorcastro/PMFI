using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaTiposProjetoAtividade
    {
        public short IdTipoProjetoAtividade { get; set; }
        public string? DsTipoProjetoAtividade { get; set; }
        public string? CdInicio { get; set; }
        public string? CdTipoAcao { get; set; }
    }
}
