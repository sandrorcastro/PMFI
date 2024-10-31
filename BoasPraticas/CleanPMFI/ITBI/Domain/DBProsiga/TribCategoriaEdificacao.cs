using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribCategoriaEdificacao
    {
        public TribCategoriaEdificacao()
        {
            TribPlantaValores = new HashSet<TribPlantaValore>();
            TribTipoPlantasValores = new HashSet<TribTipoPlantasValore>();
        }

        public int CategId { get; set; }
        public string? CategNome { get; set; }
        public int? CategDe { get; set; }
        public int? CategAte { get; set; }

        public virtual ICollection<TribPlantaValore> TribPlantaValores { get; set; }
        public virtual ICollection<TribTipoPlantasValore> TribTipoPlantasValores { get; set; }
    }
}
