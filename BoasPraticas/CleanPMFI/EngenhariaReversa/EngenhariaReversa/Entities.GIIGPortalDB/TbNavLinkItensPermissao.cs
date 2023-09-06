using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbNavLinkItensPermissao
    {
        public int IdLinkItem { get; set; }
        public string DsLogin { get; set; } = null!;

        public virtual TbNavLinkIten IdLinkItemNavigation { get; set; } = null!;
    }
}
