using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbConSolicitacaoInscricaoCmcdocumentosAnalise
    {
        public int IdAnaliseSetor { get; set; }
        public string? IdSolicitacaoInscricaoDocumento { get; set; }
        public int? IdSetor { get; set; }
        public string? DsParecer { get; set; }
        public DateTime? DtParecer { get; set; }
        public string? FlStatus { get; set; }
        public string? Dslogin { get; set; }
    }
}
