using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspTiposObjetivoDiarium
    {
        public TbDspTiposObjetivoDiarium()
        {
            TbDspDiaria = new HashSet<TbDspDiaria>();
        }

        public short IdTipoObjetivoDiaria { get; set; }
        public string? DsTipoObjetivoDiaria { get; set; }

        public virtual ICollection<TbDspDiaria> TbDspDiaria { get; set; }
    }
}
