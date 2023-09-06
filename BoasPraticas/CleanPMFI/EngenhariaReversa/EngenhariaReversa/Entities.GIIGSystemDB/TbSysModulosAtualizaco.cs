using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSysModulosAtualizaco
    {
        public int IdAtualizacao { get; set; }
        public short IdModulo { get; set; }
        public int? IdVersao { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public string? DsLogin { get; set; }
    }
}
