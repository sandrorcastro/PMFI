using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspDespesaExtraOrcamentariaDevReceita
    {
        public int IdDespesa { get; set; }
        public int IdReceita { get; set; }
        public decimal? VlDevolvido { get; set; }

        public virtual TbDspDespesaExtraOrcamentarium IdDespesaNavigation { get; set; } = null!;
        public virtual TbOrcReceita IdReceitaNavigation { get; set; } = null!;
    }
}
