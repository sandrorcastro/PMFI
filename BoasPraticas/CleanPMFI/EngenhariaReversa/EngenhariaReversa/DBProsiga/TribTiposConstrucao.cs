using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTiposConstrucao
    {
        public TribTiposConstrucao()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
            TribPlantaValores = new HashSet<TribPlantaValore>();
        }

        public int TipoConId { get; set; }
        public string? TipoConNome { get; set; }
        public decimal? TipoConFator { get; set; }
        public int? TipoConPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
        public virtual ICollection<TribPlantaValore> TribPlantaValores { get; set; }
    }
}
