using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcReceitasReestimadasFonte
    {
        public int IdReestimativa { get; set; }
        public int IdFonte { get; set; }
        public decimal? VlReestimado { get; set; }
    }
}
