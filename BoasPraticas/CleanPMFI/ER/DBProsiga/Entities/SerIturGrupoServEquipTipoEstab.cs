using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SerIturGrupoServEquipTipoEstab
{
    public int GrupoServEquipId { get; set; }

    public int TipoEstabId { get; set; }

    public int TipoInfraEstId { get; set; }

    public int? Ordem { get; set; }

    public virtual SerIturGrupoServEquip GrupoServEquip { get; set; } = null!;

    public virtual SerIturTipoEstabelecimento TipoEstab { get; set; } = null!;

    public virtual SerIturTipoInfraEstrutura TipoInfraEst { get; set; } = null!;
}
