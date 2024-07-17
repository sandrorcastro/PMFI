using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerFormataCampo
    {
        public int NrAno { get; set; }
        public string DsTipo { get; set; } = null!;
        public string DsCampo { get; set; } = null!;
        public short? NrInicio { get; set; }
        public short? NrTamanho { get; set; }
    }
}
