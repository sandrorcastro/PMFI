using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbForLogAutenticacao
    {
        public long IdLog { get; set; }
        public string? DsIp { get; set; }
        public string? NrCnpjcpf { get; set; }
        public DateTime? DtOcorrencia { get; set; }
        public string? DsSessionId { get; set; }
        public string? DsOcorrencia { get; set; }
    }
}
