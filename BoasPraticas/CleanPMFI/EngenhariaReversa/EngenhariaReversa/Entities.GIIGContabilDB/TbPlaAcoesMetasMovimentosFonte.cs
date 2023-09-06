using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaAcoesMetasMovimentosFonte
    {
        public int IdMovimento { get; set; }
        public string CdFonte { get; set; } = null!;
        public decimal? VlEstimado { get; set; }
        public string? FlCorrenteCapital { get; set; }

        public virtual TbPlaAcoesMetasMovimento IdMovimentoNavigation { get; set; } = null!;
    }
}
