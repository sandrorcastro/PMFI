using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class EdutipoLocal
    {
        public EdutipoLocal()
        {
            Localizacaos = new HashSet<Localizacao>();
        }

        public long TipoLocId { get; set; }
        public string? TipoLocNome { get; set; }

        public virtual ICollection<Localizacao> Localizacaos { get; set; }
    }
}
