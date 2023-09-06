using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbForDownloadsLicitaco
    {
        public int IdLicitacao { get; set; }
        public int IdObjeto { get; set; }
        public DateTime? DtMaxDownload { get; set; }

        public virtual TbForDownloadsLicitacoesObjeto IdObjetoNavigation { get; set; } = null!;
    }
}
