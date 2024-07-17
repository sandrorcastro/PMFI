using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbDspTipoObjetoDespesa
    {
        public int IdTipoObjetoDespesa { get; set; }
        public string? DsTipoObjetoDespesa { get; set; }
        public short? IdTipoCategoria { get; set; }

        public virtual TbDspTipoCategoriaObjetoDespesa? IdTipoCategoriaNavigation { get; set; }
    }
}
