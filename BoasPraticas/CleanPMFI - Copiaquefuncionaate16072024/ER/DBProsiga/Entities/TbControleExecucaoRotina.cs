using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbControleExecucaoRotina
{
    public int IdControle { get; set; }

    public DateTime? DtUltimaExecucao { get; set; }
}
