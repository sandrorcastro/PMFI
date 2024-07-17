using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbNavPaginasPadrao
    {
        public int IdPaginaPadrao { get; set; }
        public int? IdLinkItem { get; set; }
        public string? DsCorpoPagina { get; set; }
        public string? FlUsaTituloPagina { get; set; }

        public virtual TbNavLinkIten? IdLinkItemNavigation { get; set; }
    }
}
