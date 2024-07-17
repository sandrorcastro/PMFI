using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPpaFontesOrgao
    {
        public short IdEmpresa { get; set; }
        public short NrAno { get; set; }
        public string CdOrgao { get; set; } = null!;
        public string CdFonte { get; set; } = null!;
    }
}
