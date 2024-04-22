using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbConSolicitacaoInscricaoCmclaudoBombeiro
    {
        public long IdSolicitacaoInscricaoLaudoBombeiro { get; set; }
        public long? IdSolicitacaoInscricao { get; set; }
        public long? NrLaudo { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtValidade { get; set; }
        public DateTime? DtVistoria { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public string? DsObservacao { get; set; }
    }
}
