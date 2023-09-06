using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcReceitasOrcamentoAnualFonte
    {
        public int IdReceitaOrcamentoAnual { get; set; }
        public int IdFonte { get; set; }
        public decimal? VlOrcado { get; set; }
    }
}
