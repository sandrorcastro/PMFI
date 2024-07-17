using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SerIturAtrativosServicosEquipamento
    {
        public long AtrativoId { get; set; }
        public int GrupoServEquipId { get; set; }
        public int ServEquipId { get; set; }
        public string? ParamTipo { get; set; }
        public string? Param1 { get; set; }
        public string? Param2 { get; set; }

        public virtual SerIturAtrativosTuristico Atrativo { get; set; } = null!;
        public virtual SerIturServEquipGrupo SerIturServEquipGrupo { get; set; } = null!;
    }
}
