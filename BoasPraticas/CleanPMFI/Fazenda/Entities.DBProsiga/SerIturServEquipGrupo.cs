using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SerIturServEquipGrupo
{
    public int GrupoServEquipId { get; set; }

    public int ServEquipId { get; set; }

    public int? OrdemServEquip { get; set; }

    public virtual SerIturGrupoServEquip GrupoServEquip { get; set; } = null!;

    public virtual ICollection<SerIturAtrativosServicosEquipamento> SerIturAtrativosServicosEquipamentos { get; set; } = new List<SerIturAtrativosServicosEquipamento>();

    public virtual ICollection<SerIturEmpresaServicosEquipamento> SerIturEmpresaServicosEquipamentos { get; set; } = new List<SerIturEmpresaServicosEquipamento>();

    public virtual SerIturServicosEquipamento ServEquip { get; set; } = null!;
}
