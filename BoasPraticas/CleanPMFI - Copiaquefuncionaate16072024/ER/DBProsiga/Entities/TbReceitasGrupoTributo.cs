using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbReceitasGrupoTributo
{
    public string Receita { get; set; } = null!;

    public int TrGrId { get; set; }
}
