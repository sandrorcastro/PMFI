using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinTipoOperacaoProgramacaoFinanceira
    {
        public TbFinTipoOperacaoProgramacaoFinanceira()
        {
            TbFinCronogramaDesembolsos = new HashSet<TbFinCronogramaDesembolso>();
        }

        public short IdTipoOperacao { get; set; }
        public string? DsTipoOperacao { get; set; }

        public virtual ICollection<TbFinCronogramaDesembolso> TbFinCronogramaDesembolsos { get; set; }
    }
}
