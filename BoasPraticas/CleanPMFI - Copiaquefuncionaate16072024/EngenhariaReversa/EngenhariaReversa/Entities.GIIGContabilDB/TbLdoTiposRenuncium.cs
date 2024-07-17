using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLdoTiposRenuncium
    {
        public TbLdoTiposRenuncium()
        {
            TbLdoDemRenunciaReceita = new HashSet<TbLdoDemRenunciaReceitum>();
        }

        public short IdTipoRenuncia { get; set; }
        public string? DsTipoRenuncia { get; set; }

        public virtual ICollection<TbLdoDemRenunciaReceitum> TbLdoDemRenunciaReceita { get; set; }
    }
}
