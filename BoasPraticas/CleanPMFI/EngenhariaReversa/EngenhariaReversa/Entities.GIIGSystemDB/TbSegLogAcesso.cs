using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSegLogAcesso
    {
        public long IdLog { get; set; }
        public string? DsIp { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtLogIn { get; set; }
        public DateTime? DtLogOut { get; set; }
        public string? DsSessionId { get; set; }
        public DateTime? DtUltInteracao { get; set; }
        public string? NmForm { get; set; }
    }
}
