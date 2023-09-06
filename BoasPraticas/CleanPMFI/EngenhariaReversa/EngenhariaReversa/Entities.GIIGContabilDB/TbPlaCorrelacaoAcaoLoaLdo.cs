using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaCorrelacaoAcaoLoaLdo
    {
        public int IdAcaoCorrelacao { get; set; }
        public int IdAcao { get; set; }
        public int? IdVersaoCorrelacao { get; set; }
    }
}
