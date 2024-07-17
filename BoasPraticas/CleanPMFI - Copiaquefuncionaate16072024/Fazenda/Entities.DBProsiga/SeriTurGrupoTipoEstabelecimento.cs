using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SeriTurGrupoTipoEstabelecimento
{
    public short GrTiId { get; set; }

    public string? GrTiDescricao { get; set; }

    public long? ObjId { get; set; }

    public short? GrTiOrdem { get; set; }

    public virtual SerIturObjeto? Obj { get; set; }

    public virtual ICollection<SerIturTipoEstabelecimento> SerIturTipoEstabelecimentos { get; set; } = new List<SerIturTipoEstabelecimento>();
}
