using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapTiposAditivo
    {
        public TbCapTiposAditivo()
        {
            TbCapAditivosConvenios = new HashSet<TbCapAditivosConvenio>();
        }

        public short IdTipoAditivo { get; set; }
        public string? DsTipoAditivo { get; set; }

        public virtual ICollection<TbCapAditivosConvenio> TbCapAditivosConvenios { get; set; }
    }
}
