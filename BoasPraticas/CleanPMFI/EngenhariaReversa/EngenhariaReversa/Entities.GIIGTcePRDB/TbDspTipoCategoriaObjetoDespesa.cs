using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbDspTipoCategoriaObjetoDespesa
    {
        public TbDspTipoCategoriaObjetoDespesa()
        {
            TbDspTipoObjetoDespesas = new HashSet<TbDspTipoObjetoDespesa>();
        }

        public short IdTipoCategoria { get; set; }
        public string? DsTipoCategoria { get; set; }

        public virtual ICollection<TbDspTipoObjetoDespesa> TbDspTipoObjetoDespesas { get; set; }
    }
}
