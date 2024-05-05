using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class VisaoRelatorioServiçosEquipamento
{
    public int? Qtde { get; set; }

    public short GrTiId { get; set; }

    public string? GrTiDescricao { get; set; }

    public int TipoEstabId { get; set; }

    public int ServEquipId { get; set; }

    public string? TipoEstabNome { get; set; }

    public string? ServEquipNome { get; set; }

    public string? GrupoServEquipNome { get; set; }

    public string? EmprInfraNome { get; set; }
}
