using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbPubCategoria
    {
        public TbPubCategoria()
        {
            TbPubArquivos = new HashSet<TbPubArquivo>();
        }

        public int IdCategoria { get; set; }
        public string? NmCategoria { get; set; }
        public string? DsCategoria { get; set; }
        public int? IdLinkItem { get; set; }
        public bool? FlPadrao { get; set; }

        public virtual TbNavLinkIten? IdLinkItemNavigation { get; set; }
        public virtual ICollection<TbPubArquivo> TbPubArquivos { get; set; }
    }
}
