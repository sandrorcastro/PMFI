using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbAciTipoUnidade
    {
        public TbAciTipoUnidade()
        {
            TbAciUnidades = new HashSet<TbAciUnidade>();
        }

        public int IdTipoUnidade { get; set; }
        public short? CdTipoUnidade { get; set; }
        public string? DsTipoUnidade { get; set; }

        public virtual ICollection<TbAciUnidade> TbAciUnidades { get; set; }
    }
}
