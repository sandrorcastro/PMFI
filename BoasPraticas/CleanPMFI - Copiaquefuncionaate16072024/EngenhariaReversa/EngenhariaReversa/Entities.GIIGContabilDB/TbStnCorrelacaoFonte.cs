using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbStnCorrelacaoFonte
    {
        public int IdCorrelacao { get; set; }
        public string? CdFonteGiig { get; set; }
        public string? CdFonteStn { get; set; }
        public short? NrAno { get; set; }
    }
}
