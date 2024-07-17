using Domain.Entities.DBProsiga;
using Domain.Filters.DBProsiga;
using System;
using System.Collections.Generic;

namespace Application.ViewModels.DBProsiga

{
    public class CidadeViewModel
    {
        public int IdCidade { get; set; }
        public int? IdUf { get; set; }
        public string Nome { get; set; } = null!;
        public int? IdPais { get; set; }
        public int? CodigoIbge { get; set; }
        public string SinCapital { get; set; } = null!;
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public virtual Paise? IdPaisNavigation { get; set; }
       // public virtual Uf? IdUfNavigation { get; set; }
       // public CidadeFilter CidadeFilter { get; set; }
    }
}
