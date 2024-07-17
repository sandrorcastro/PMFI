using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbNfseLayoutDefault
    {
        public int IdSistema { get; set; }
        public int IdEmpresa { get; set; }
        public string? DsTituloPrincipal { get; set; }
        public string? DsTextoPrincipal { get; set; }
        public string? LnkSistemaNfse { get; set; }
    }
}
