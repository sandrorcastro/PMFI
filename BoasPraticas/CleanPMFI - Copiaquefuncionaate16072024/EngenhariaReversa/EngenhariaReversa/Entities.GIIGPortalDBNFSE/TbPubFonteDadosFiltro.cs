using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbPubFonteDadosFiltro
    {
        public TbPubFonteDadosFiltro()
        {
            IdVisaos = new HashSet<TbPubVisaoFonteDado>();
        }

        public int IdFonteDadosFiltro { get; set; }
        public string? DsTipoFiltro { get; set; }
        public short? NrOrdem { get; set; }
        public string? DsRotuloControle { get; set; }
        public string? DsCampos { get; set; }
        public string? DsTipoCampos { get; set; }
        public string? NrTamanhosCampos { get; set; }
        public string? FlObrigatorio { get; set; }
        public int? IdFonteDados { get; set; }
        public string? VlPadrao { get; set; }
        public string? DsAliasCampos { get; set; }
        public string? FlUsaLike { get; set; }

        public virtual TbPubFonteDado? IdFonteDadosNavigation { get; set; }

        public virtual ICollection<TbPubVisaoFonteDado> IdVisaos { get; set; }
    }
}
