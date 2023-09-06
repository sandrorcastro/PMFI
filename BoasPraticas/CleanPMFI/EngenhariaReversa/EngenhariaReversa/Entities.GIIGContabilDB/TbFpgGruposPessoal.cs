using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFpgGruposPessoal
    {
        public TbFpgGruposPessoal()
        {
            TbFpgGrupoPessoalNaturezas = new HashSet<TbFpgGrupoPessoalNatureza>();
        }

        public short IdGrupo { get; set; }
        public string? DsGrupo { get; set; }

        public virtual ICollection<TbFpgGrupoPessoalNatureza> TbFpgGrupoPessoalNaturezas { get; set; }
    }
}
