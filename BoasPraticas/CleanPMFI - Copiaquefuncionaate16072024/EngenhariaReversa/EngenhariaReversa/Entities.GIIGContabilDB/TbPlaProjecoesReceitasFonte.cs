using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaProjecoesReceitasFonte
    {
        public int IdProjecao { get; set; }
        public int IdFonte { get; set; }
        public short? CdArea { get; set; }
        public decimal? VlEstimado { get; set; }
    }
}
