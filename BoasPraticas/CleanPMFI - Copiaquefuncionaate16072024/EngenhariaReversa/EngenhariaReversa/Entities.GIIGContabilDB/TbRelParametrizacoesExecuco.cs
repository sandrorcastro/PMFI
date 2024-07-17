using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRelParametrizacoesExecuco
    {
        public int IdExecucao { get; set; }
        public int IdDetalheFormula { get; set; }
        public decimal? VlExecutado { get; set; }

        public virtual TbRelParametrizacoesDetalhesFormula IdDetalheFormulaNavigation { get; set; } = null!;
        public virtual TbRelExecucoesRelatorio IdExecucaoNavigation { get; set; } = null!;
    }
}
