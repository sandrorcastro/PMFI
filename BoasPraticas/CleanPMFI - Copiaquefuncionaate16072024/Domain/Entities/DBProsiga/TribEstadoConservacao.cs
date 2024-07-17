using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEstadoConservacao
    {
        public TribEstadoConservacao()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int EstConservId { get; set; }
        public string? EstConservNome { get; set; }
        public decimal? EstConservFator { get; set; }
        public int? EstConservPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
