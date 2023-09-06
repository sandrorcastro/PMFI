using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class TbRelatoriosColuna
    {
        public int IdRelatorio { get; set; }
        public int IdColuna { get; set; }
        public string? DsCondicao { get; set; }
        public string? DsOperador { get; set; }
        public string? DsFiltro { get; set; }
        public bool? FlAgrupar { get; set; }
        public string? DsAgrupador { get; set; }

        public virtual TbColuna IdColunaNavigation { get; set; } = null!;
        public virtual TbRelatorio IdRelatorioNavigation { get; set; } = null!;
    }
}
