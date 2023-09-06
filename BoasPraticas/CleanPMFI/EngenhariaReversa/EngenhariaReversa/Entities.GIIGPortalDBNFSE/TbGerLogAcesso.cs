using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbGerLogAcesso
    {
        public int IdLogAcesso { get; set; }
        public int? IdSistema { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdLinkItem { get; set; }
        public string? DsIp { get; set; }
        public string? DsUrl { get; set; }
        public DateTime? DtAcesso { get; set; }
        public string? NmNavegador { get; set; }
    }
}
