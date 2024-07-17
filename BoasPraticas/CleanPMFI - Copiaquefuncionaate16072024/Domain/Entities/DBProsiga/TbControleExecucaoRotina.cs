using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbControleExecucaoRotina
    {
        public int IdControle { get; set; }
        public DateTime? DtUltimaExecucao { get; set; }
    }
}
