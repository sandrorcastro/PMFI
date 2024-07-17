using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEnquadramentoNotificacaoEmpresa
    {
        public int IdNotificacao { get; set; }
        public long EnquadrId { get; set; }
        public string? FlVerificado { get; set; }

        public virtual TribEmpresasEnquadramento Enquadr { get; set; } = null!;
        public virtual TribEnquadramentoNotificacao IdNotificacaoNavigation { get; set; } = null!;
    }
}
