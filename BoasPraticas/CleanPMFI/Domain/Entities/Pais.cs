using System;
using System.Collections.Generic;

namespace Domain.Entities
{ 
    public partial class Pais
    {
        public Pais()
        {
            Cidades = new HashSet<Cidade>();
            Ufs = new HashSet<Uf>();
        }

        public int IdPais { get; set; }
        public string Nome { get; set; } = null!;

        public virtual ICollection<Cidade> Cidades { get; set; }
        public virtual ICollection<Uf> Ufs { get; set; }
    }
}
