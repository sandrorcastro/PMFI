using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbReceitasGrupoTributo
{
    public string Receita { get; set; } = null!;

    public int TrGrId { get; set; }
}
