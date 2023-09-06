using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbForDownloadsLicitacoesObjeto
    {
        public TbForDownloadsLicitacoesObjeto()
        {
            TbForDownloadsLicitacos = new HashSet<TbForDownloadsLicitaco>();
        }

        public int IdObjeto { get; set; }
        public string? NmObjeto { get; set; }
        public string? DsObjeto { get; set; }

        public virtual ICollection<TbForDownloadsLicitaco> TbForDownloadsLicitacos { get; set; }
    }
}
