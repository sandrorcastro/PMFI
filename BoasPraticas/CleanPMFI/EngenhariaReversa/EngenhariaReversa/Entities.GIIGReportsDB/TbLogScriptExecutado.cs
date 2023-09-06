using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class TbLogScriptExecutado
    {
        public int IdLog { get; set; }
        public string? DsIp { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtLog { get; set; }
        public string? NmBaseDados { get; set; }
        public string? DsSql { get; set; }
        public string? DsLoginDba { get; set; }
    }
}
