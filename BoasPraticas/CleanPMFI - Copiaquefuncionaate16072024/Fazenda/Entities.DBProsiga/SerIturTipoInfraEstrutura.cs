using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SerIturTipoInfraEstrutura
{
    public int TipoInfraEstId { get; set; }

    public string? TipoInfraEstNome { get; set; }

    public virtual ICollection<SerIturEmpresaInfraEstrutura> SerIturEmpresaInfraEstruturas { get; set; } = new List<SerIturEmpresaInfraEstrutura>();

    public virtual ICollection<SerIturGrupoServEquipTipoEstab> SerIturGrupoServEquipTipoEstabs { get; set; } = new List<SerIturGrupoServEquipTipoEstab>();
}
