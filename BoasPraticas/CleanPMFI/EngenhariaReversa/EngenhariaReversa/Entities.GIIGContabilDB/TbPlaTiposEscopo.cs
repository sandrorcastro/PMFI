using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaTiposEscopo
    {
        public TbPlaTiposEscopo()
        {
            TbPlaEscopos = new HashSet<TbPlaEscopo>();
        }

        public short IdTipoEscopo { get; set; }
        public string? DsTipoEscopo { get; set; }

        public virtual ICollection<TbPlaEscopo> TbPlaEscopos { get; set; }
    }
}
