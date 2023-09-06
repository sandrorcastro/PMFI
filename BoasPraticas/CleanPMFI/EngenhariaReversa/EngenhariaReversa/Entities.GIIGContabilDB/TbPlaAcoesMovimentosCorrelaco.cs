using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaAcoesMovimentosCorrelaco
    {
        public int IdMovimentoCorrelacao { get; set; }
        public int? IdAcao { get; set; }
        public int? IdMovimento { get; set; }
        public int? IdVersaoMovimento { get; set; }
    }
}
