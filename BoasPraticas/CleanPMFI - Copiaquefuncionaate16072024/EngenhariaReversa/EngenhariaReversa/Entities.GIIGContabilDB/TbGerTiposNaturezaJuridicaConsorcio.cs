using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerTiposNaturezaJuridicaConsorcio
    {
        public TbGerTiposNaturezaJuridicaConsorcio()
        {
            TbGerConsorciosMunicipios = new HashSet<TbGerConsorciosMunicipio>();
        }

        public short IdTipoNaturezaJuridica { get; set; }
        public string? DsTipoNaturezaJuridica { get; set; }

        public virtual ICollection<TbGerConsorciosMunicipio> TbGerConsorciosMunicipios { get; set; }
    }
}
