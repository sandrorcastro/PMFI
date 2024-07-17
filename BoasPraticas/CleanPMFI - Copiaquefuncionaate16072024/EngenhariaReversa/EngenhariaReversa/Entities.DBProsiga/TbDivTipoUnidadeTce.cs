using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbDivTipoUnidadeTce
    {
        public TbDivTipoUnidadeTce()
        {
            TbDivInscricaoSancaos = new HashSet<TbDivInscricaoSancao>();
        }

        public short IdTipoUnidadeTce { get; set; }
        public string? DsTipoUnidadeTce { get; set; }

        public virtual ICollection<TbDivInscricaoSancao> TbDivInscricaoSancaos { get; set; }
    }
}
