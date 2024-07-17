using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Uf
    {
        public Uf()
        {
            Cidades = new HashSet<Cidade>();
        }

        public int IdUf { get; set; }
        public string? Sigla { get; set; }
        public string Nome { get; set; } = null!;
        public int IdPais { get; set; }
        public int? CodigoIbge { get; set; }

        public virtual Pais IdPaisNavigation { get; set; } = null!;
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
