using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcReceitasEstornoOrcamentoFonte
    {
        public int IdEstorno { get; set; }
        public int IdFonte { get; set; }
        public decimal? VlOrcado { get; set; }
    }
}
