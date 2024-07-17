using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbForLicitacoesParticipante
    {
        public int IdLicitacao { get; set; }
        public int IdFornecedor { get; set; }

        public virtual TbForFornecedore IdFornecedorNavigation { get; set; } = null!;
    }
}
