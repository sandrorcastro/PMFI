using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SerIturTipoEstabelecimento
{
    public int TipoEstabId { get; set; }

    public string? TipoEstabNome { get; set; }

    public short? GrTiId { get; set; }

    public virtual SeriTurGrupoTipoEstabelecimento? GrTi { get; set; }

    public virtual ICollection<SerIturEmpresaInfraEstrutura> SerIturEmpresaInfraEstruturas { get; set; } = new List<SerIturEmpresaInfraEstrutura>();

    public virtual ICollection<SerIturGrupoServEquipTipoEstab> SerIturGrupoServEquipTipoEstabs { get; set; } = new List<SerIturGrupoServEquipTipoEstab>();

    public virtual ICollection<TribAtivGrupo> AtivGrupos { get; set; } = new List<TribAtivGrupo>();
}
