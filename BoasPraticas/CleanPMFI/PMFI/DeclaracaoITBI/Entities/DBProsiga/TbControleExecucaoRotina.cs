using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TbControleExecucaoRotina
{
    public int IdControle { get; set; }

    public DateTime? DtUltimaExecucao { get; set; }
}
