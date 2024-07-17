using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSysFormulariosAtalho
    {
        public int IdAtalho { get; set; }
        public string? DsLogin { get; set; }
        public short? IdFormLocal { get; set; }
        public short? IdFormAtalho { get; set; }
        public string? DsAccessKey { get; set; }
    }
}
