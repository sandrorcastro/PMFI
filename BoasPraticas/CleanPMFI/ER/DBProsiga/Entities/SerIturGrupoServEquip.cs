using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SerIturGrupoServEquip
{
    public int GrupoServEquipId { get; set; }

    public string? GrupoServEquipNome { get; set; }

    public string? GrupoServDispEmpresas { get; set; }

    public string? GrupoServDispAtrativos { get; set; }

    public int? GrupoServOrdem { get; set; }

    public string? GrupoServExterno { get; set; }

    public virtual ICollection<SerIturGrupoServEquipTipoEstab> SerIturGrupoServEquipTipoEstabs { get; set; } = new List<SerIturGrupoServEquipTipoEstab>();

    public virtual ICollection<SerIturServEquipGrupo> SerIturServEquipGrupos { get; set; } = new List<SerIturServEquipGrupo>();
}
