using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbNavLinkIten
    {
        public TbNavLinkIten()
        {
            TbNavPaginasPadraos = new HashSet<TbNavPaginasPadrao>();
            TbPubCategoria = new HashSet<TbPubCategoria>();
            TbPubVisaoFonteDados = new HashSet<TbPubVisaoFonteDado>();
        }

        public int IdLinkItem { get; set; }
        public string? NmLinkItem { get; set; }
        public string? DsLinkItem { get; set; }
        public string? DsTituloPagina { get; set; }
        public string? Dslink { get; set; }
        public string? FlUsaPaginaPadrao { get; set; }
        public string? FlManutencao { get; set; }
        public string? FlVisivel { get; set; }
        public short? NrOrdem { get; set; }
        public int? IdLinkModulo { get; set; }
        public int? NrVisualizacoes { get; set; }

        public virtual TbNavLinkModulo? IdLinkModuloNavigation { get; set; }
        public virtual ICollection<TbNavPaginasPadrao> TbNavPaginasPadraos { get; set; }
        public virtual ICollection<TbPubCategoria> TbPubCategoria { get; set; }
        public virtual ICollection<TbPubVisaoFonteDado> TbPubVisaoFonteDados { get; set; }
    }
}
