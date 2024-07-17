using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSegUsuariosParametro
    {
        public string DsLogin { get; set; } = null!;
        public string NmParametro { get; set; } = null!;
        public string? DsParametro { get; set; }
        public string? VlParametro { get; set; }
    }
}
