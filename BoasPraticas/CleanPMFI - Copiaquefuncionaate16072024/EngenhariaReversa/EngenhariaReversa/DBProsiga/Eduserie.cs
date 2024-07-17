using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Eduserie
    {
        public Eduserie()
        {
            Eduturmas = new HashSet<Eduturma>();
            Discs = new HashSet<Edudisciplina>();
        }

        public long SerieId { get; set; }
        public string? SerieSerie { get; set; }
        public long? TipoSerId { get; set; }

        public virtual EdutipoSerie? TipoSer { get; set; }
        public virtual ICollection<Eduturma> Eduturmas { get; set; }

        public virtual ICollection<Edudisciplina> Discs { get; set; }
    }
}
