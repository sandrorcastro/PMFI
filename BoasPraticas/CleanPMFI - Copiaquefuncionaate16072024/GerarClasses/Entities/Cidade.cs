using System;
using System.Collections.Generic;

namespace GerarClasses.Entities
{
    public partial class Cidade
    {
        public int IdCidade { get; set; }
        public int? IdUf { get; set; }
        public string Nome { get; set; } = null!;
        public int? IdPais { get; set; }
        public int? CodigoIbge { get; set; }
        public string SinCapital { get; set; } = null!;
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public virtual Pais? IdPaisNavigation { get; set; }
        public virtual Uf? IdUfNavigation { get; set; }
    }
}
