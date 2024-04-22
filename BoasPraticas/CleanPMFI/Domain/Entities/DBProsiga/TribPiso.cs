using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribPiso
    {
        public TribPiso()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int PisoId { get; set; }
        public string? PisoNome { get; set; }
        public decimal? PisoFator { get; set; }
        public int? PisoPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
