using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTipoPlantasValore
    {
        public TribTipoPlantasValore()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
            TribParamCalculos = new HashSet<TribParamCalculo>();
        }

        public int Idplanta { get; set; }
        public string? NomePlanta { get; set; }
        public decimal? ValorM2 { get; set; }
        public int? AnoPlanta { get; set; }
        public int? CategId { get; set; }
        public int? IdplantaOrigem { get; set; }

        public virtual TribCategoriaEdificacao? Categ { get; set; }
        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }

        public virtual ICollection<TribParamCalculo> TribParamCalculos { get; set; }
    }
}
