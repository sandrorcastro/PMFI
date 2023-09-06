using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbPubArquivosListum
    {
        public int IdArquivo { get; set; }
        public string? DsNomeArquivo { get; set; }
        public string? DsArquivo { get; set; }
        public string? NmArquivo { get; set; }
        public string? DsExtensaoArquivo { get; set; }
        public byte[]? BnArquivo { get; set; }
        public DateTime? DtPublicacao { get; set; }
        public string? DsLogin { get; set; }
        public int? IdLinkItem { get; set; }
        public int? IdSistema { get; set; }
    }
}
