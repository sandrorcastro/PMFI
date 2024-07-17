using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class GruposServico
    {
        public GruposServico()
        {
            Formularios = new HashSet<Formulario>();
        }

        public int GsvId { get; set; }
        public string? GsvNome { get; set; }

        public virtual ICollection<Formulario> Formularios { get; set; }
    }
}
