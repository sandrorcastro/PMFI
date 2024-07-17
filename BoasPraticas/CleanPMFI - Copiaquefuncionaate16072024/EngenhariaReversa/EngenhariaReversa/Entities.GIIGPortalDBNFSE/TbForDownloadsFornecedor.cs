using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbForDownloadsFornecedor
    {
        public int IdFornecedor { get; set; }
        public int IdLicitacao { get; set; }
        public int IdObjeto { get; set; }
        public int? NrDownloads { get; set; }
        public DateTime? DtUltimoDowload { get; set; }

        public virtual TbForFornecedore IdFornecedorNavigation { get; set; } = null!;
    }
}
