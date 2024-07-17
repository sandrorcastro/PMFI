using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinTipoVariacaoQualitativa
    {
        public TbFinTipoVariacaoQualitativa()
        {
            TbFinLancamentosPartidaDobrada = new HashSet<TbFinLancamentosPartidaDobrada>();
        }

        public short IdTipoVariacao { get; set; }
        public string? DsTipoVariacao { get; set; }

        public virtual ICollection<TbFinLancamentosPartidaDobrada> TbFinLancamentosPartidaDobrada { get; set; }
    }
}
