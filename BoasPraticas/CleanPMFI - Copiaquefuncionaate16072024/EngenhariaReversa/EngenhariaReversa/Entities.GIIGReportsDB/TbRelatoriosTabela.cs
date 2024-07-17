using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class TbRelatoriosTabela
    {
        public int IdRelatorio { get; set; }
        public int IdTabela { get; set; }
        public bool? FlPrincipal { get; set; }

        public virtual TbRelatorio IdRelatorioNavigation { get; set; } = null!;
        public virtual TbTabela IdTabelaNavigation { get; set; } = null!;
    }
}
