using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEsquadria
    {
        public TribEsquadria()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int EsquadriasId { get; set; }
        public string? EsquadriasNome { get; set; }
        public decimal? EsquadriasFator { get; set; }
        public int? EsquadriasPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
