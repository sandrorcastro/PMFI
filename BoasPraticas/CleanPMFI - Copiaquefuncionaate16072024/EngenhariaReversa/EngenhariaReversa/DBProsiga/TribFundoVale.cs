using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFundoVale
    {
        public TribFundoVale()
        {
            TribTerrenos = new HashSet<TribTerreno>();
        }

        public int FundoId { get; set; }
        public string? FundoNome { get; set; }
        public decimal? FundoFator { get; set; }
        public int FundoPontos { get; set; }

        public virtual ICollection<TribTerreno> TribTerrenos { get; set; }
    }
}
