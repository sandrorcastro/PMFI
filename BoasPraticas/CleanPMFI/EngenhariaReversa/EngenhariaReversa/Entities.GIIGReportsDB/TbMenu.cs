using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class TbMenu
    {
        public string DsLogin { get; set; } = null!;
        public bool? FlConfiguracoes { get; set; }
        public bool? FlUsuarios { get; set; }
        public bool FlConsulta { get; set; }
    }
}
