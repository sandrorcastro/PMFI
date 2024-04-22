using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbConSolicitacaoInscricaoCmcdocumento
    {
        public long IdSolicitacaoInscricaoDocumento { get; set; }
        public long? IdSolicitacaoInscricao { get; set; }
        public int? ObjetoId { get; set; }
        public string? DsNomeDocumento { get; set; }

        public virtual TbConSolicitacaoInscricaoCmc? IdSolicitacaoInscricaoNavigation { get; set; }
        public virtual TribObjeto? Objeto { get; set; }
    }
}
