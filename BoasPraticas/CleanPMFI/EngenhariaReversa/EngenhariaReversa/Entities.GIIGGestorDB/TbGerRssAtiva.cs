using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGGestorDB
{
    public partial class TbGerRssAtiva
    {
        public int IdRssPadrao { get; set; }
        public int IdRssUsuario { get; set; }
        public string DsLogin { get; set; } = null!;
        public string? DsNomeRss { get; set; }
    }
}
