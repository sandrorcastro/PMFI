using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaAreasProjecaoReceitum
    {
        public TbPlaAreasProjecaoReceitum()
        {
            TbPlaProjecoesReceita = new HashSet<TbPlaProjecoesReceita>();
        }

        public short CdArea { get; set; }
        public string? DsArea { get; set; }

        public virtual ICollection<TbPlaProjecoesReceita> TbPlaProjecoesReceita { get; set; }
    }
}
