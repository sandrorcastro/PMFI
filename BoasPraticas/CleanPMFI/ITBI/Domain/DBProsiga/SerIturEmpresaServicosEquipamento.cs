using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SerIturEmpresaServicosEquipamento
    {
        public int EmprInfraId { get; set; }
        public int GrupoServEquipId { get; set; }
        public int ServEquipId { get; set; }
        public string? ParamTipo { get; set; }
        public string? Param1 { get; set; }
        public string? Param2 { get; set; }
        public int? Ordem { get; set; }

        public virtual SerIturEmpresaInfraEstrutura EmprInfra { get; set; } = null!;
        public virtual SerIturServEquipGrupo SerIturServEquipGrupo { get; set; } = null!;
    }
}
