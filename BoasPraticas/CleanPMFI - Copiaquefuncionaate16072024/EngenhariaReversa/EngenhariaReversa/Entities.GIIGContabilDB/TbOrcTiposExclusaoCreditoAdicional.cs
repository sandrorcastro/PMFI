using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcTiposExclusaoCreditoAdicional
    {
        public TbOrcTiposExclusaoCreditoAdicional()
        {
            TbOrcLimitesCreditoAdicionals = new HashSet<TbOrcLimitesCreditoAdicional>();
        }

        public int IdTipoExclusao { get; set; }
        public string? DsTipoExclusao { get; set; }

        public virtual ICollection<TbOrcLimitesCreditoAdicional> TbOrcLimitesCreditoAdicionals { get; set; }
    }
}
