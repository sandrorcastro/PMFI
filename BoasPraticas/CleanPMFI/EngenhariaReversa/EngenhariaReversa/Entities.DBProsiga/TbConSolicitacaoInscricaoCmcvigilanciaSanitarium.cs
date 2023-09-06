using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbConSolicitacaoInscricaoCmcvigilanciaSanitarium
    {
        public long IdSolicitacaoInscricaoVigilanciaSanitaria { get; set; }
        public long IdSolicitacaoInscricao { get; set; }
        public int? NrLaudo { get; set; }
        public int? NrAno { get; set; }
        public DateTime? DtValidade { get; set; }
        public DateTime? DtVistoria { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public string? DsObservacao { get; set; }

        public virtual TbConSolicitacaoInscricaoCmc IdSolicitacaoInscricaoNavigation { get; set; } = null!;
    }
}
