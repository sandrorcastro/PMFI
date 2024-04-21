using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbEmpAtributosDinamico
    {
        public TbEmpAtributosDinamico()
        {
            TribEmpresasAtivAtributos = new HashSet<TribEmpresasAtivAtributo>();
        }

        public int IdAtributo { get; set; }
        public string? DsAtributo { get; set; }
        public string? DsTipoAtributo { get; set; }
        public string? DsValoresValidos { get; set; }

        public virtual ICollection<TribEmpresasAtivAtributo> TribEmpresasAtivAtributos { get; set; }
    }
}
