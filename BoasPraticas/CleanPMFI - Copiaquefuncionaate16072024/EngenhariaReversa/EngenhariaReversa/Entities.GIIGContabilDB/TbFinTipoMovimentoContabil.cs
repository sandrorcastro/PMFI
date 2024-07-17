using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinTipoMovimentoContabil
    {
        public TbFinTipoMovimentoContabil()
        {
            TbFinLancamentosPartidaDobrada = new HashSet<TbFinLancamentosPartidaDobrada>();
        }

        public short IdTipoMovimento { get; set; }
        public string? DsTipoMovimento { get; set; }

        public virtual ICollection<TbFinLancamentosPartidaDobrada> TbFinLancamentosPartidaDobrada { get; set; }
    }
}
