using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRelOrgaosUnidadesSessao
    {
        public string IdSessao { get; set; } = null!;
        public string CdOrgao { get; set; } = null!;
        public string CdUnidade { get; set; } = null!;
    }
}
