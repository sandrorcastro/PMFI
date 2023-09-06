using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerTiposAreaConsorcio
    {
        public TbGerTiposAreaConsorcio()
        {
            TbGerConsorciosMunicipios = new HashSet<TbGerConsorciosMunicipio>();
        }

        public short IdTipoAreaConsorcio { get; set; }
        public string? DsTipoAreaConsorcio { get; set; }

        public virtual ICollection<TbGerConsorciosMunicipio> TbGerConsorciosMunicipios { get; set; }
    }
}
