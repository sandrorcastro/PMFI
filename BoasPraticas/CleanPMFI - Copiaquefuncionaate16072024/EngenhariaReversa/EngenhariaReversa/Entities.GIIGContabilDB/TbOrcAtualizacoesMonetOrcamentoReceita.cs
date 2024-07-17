using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcAtualizacoesMonetOrcamentoReceita
    {
        public int IdAtualizacao { get; set; }
        public int IdReceita { get; set; }
        public decimal? VlCorrecao { get; set; }

        public virtual TbOrcAtualizacoesMonetariaOrcamento IdAtualizacaoNavigation { get; set; } = null!;
    }
}
