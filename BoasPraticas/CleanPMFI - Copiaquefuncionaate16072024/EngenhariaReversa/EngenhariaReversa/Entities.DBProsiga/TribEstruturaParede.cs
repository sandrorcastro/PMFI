using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEstruturaParede
    {
        public TribEstruturaParede()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
            TribPlantaValores = new HashSet<TribPlantaValore>();
        }

        public int EstrutId { get; set; }
        public string? EstrutNome { get; set; }
        public decimal? EstrutFator { get; set; }
        public int? EstrutPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
        public virtual ICollection<TribPlantaValore> TribPlantaValores { get; set; }
    }
}
