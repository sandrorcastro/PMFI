using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspSolicitacoesEmpenhoCancelada
    {
        public int IdCancelamento { get; set; }
        public int? IdSolicitacaoEmpenho { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbDspSolicitacoesEmpenho? IdSolicitacaoEmpenhoNavigation { get; set; }
    }
}
