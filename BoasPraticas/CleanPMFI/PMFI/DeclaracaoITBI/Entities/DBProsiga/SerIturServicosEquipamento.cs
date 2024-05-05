using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SerIturServicosEquipamento
{
    public int ServEquipId { get; set; }

    public string? ServEquipNome { get; set; }

    public string? ServEquipTipoCompl { get; set; }

    public string? ServEquipTipoDadoCompl { get; set; }

    public int? ServEquipOrdem { get; set; }

    public string? ServEquipExterno { get; set; }

    public virtual ICollection<SerIturServEquipGrupo> SerIturServEquipGrupos { get; set; } = new List<SerIturServEquipGrupo>();
}
