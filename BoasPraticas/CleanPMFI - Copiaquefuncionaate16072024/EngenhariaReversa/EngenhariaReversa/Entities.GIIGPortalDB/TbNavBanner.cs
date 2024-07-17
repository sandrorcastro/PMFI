using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbNavBanner
    {
        public int IdBanner { get; set; }
        public byte[]? BnBanner { get; set; }
        public string? DsNomeBanner { get; set; }
        public string? DsExtensaoBanner { get; set; }
        public string? DsLink { get; set; }
        public short? NrOrdem { get; set; }
        public string? FlVisivel { get; set; }
        public short? IdEmpresa { get; set; }
        public short? IdSistema { get; set; }
        public int? NrAltura { get; set; }
    }
}
