using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSysObjetosContabei
    {
        public TbSysObjetosContabei()
        {
            TbSysFilasContabeis = new HashSet<TbSysFilasContabei>();
        }

        public string CdObjeto { get; set; } = null!;
        public string? NmClasse { get; set; }
        public string? NmAnterior { get; set; }
        public string? DsSiglasIntegracao { get; set; }

        public virtual ICollection<TbSysFilasContabei> TbSysFilasContabeis { get; set; }
    }
}
