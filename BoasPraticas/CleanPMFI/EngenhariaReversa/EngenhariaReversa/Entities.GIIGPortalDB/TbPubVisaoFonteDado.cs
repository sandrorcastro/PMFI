using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbPubVisaoFonteDado
    {
        public TbPubVisaoFonteDado()
        {
            IdFonteDadosFiltros = new HashSet<TbPubFonteDadosFiltro>();
        }

        public int IdVisao { get; set; }
        public string? NmVisao { get; set; }
        public string? DsVisao { get; set; }
        public int IdFonteDados { get; set; }
        public string? DsQuery { get; set; }
        public string? FlPagina { get; set; }
        public short? NrQtdPagina { get; set; }
        public int? IdLinkItem { get; set; }
        public string? FlUsaWhere { get; set; }
        public int? NrGridWidth { get; set; }
        public string? DsUrlChamada { get; set; }
        public string? DsUrlAnexo { get; set; }
        public string? DsCamposNaoNulosSomatoria { get; set; }
        public string? DsCamposSomatoria { get; set; }

        public virtual TbPubFonteDado IdFonteDadosNavigation { get; set; } = null!;
        public virtual TbNavLinkIten? IdLinkItemNavigation { get; set; }

        public virtual ICollection<TbPubFonteDadosFiltro> IdFonteDadosFiltros { get; set; }
    }
}
