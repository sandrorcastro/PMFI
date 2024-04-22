using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Simamtributo
    {
        public Simamtributo()
        {
            SimamtributosEquivalencia = new HashSet<SimamtributosEquivalencium>();
        }

        public int TribAmcodigo { get; set; }
        public string? TribDescricao { get; set; }

        public virtual ICollection<SimamtributosEquivalencium> SimamtributosEquivalencia { get; set; }
    }
}
