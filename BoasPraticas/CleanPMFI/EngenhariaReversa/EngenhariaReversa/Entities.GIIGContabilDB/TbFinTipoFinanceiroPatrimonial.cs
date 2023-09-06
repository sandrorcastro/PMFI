using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinTipoFinanceiroPatrimonial
    {
        public TbFinTipoFinanceiroPatrimonial()
        {
            TbFinLancamentosPartidaDobrada = new HashSet<TbFinLancamentosPartidaDobrada>();
        }

        public short IdTipoFinanceiroPatrimonial { get; set; }
        public string? DsTipoFinanceiroPatrimonial { get; set; }

        public virtual ICollection<TbFinLancamentosPartidaDobrada> TbFinLancamentosPartidaDobrada { get; set; }
    }
}
