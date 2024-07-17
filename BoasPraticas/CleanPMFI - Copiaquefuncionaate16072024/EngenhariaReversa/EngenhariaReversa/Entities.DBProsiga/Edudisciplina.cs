using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Edudisciplina
    {
        public Edudisciplina()
        {
            EdudisciplinasTurmas = new HashSet<EdudisciplinasTurma>();
            Edusubstituicos = new HashSet<Edusubstituico>();
            Cons = new HashSet<Contribuinte>();
            Series = new HashSet<Eduserie>();
        }

        public long DiscId { get; set; }
        public string? DiscNome { get; set; }

        public virtual ICollection<EdudisciplinasTurma> EdudisciplinasTurmas { get; set; }
        public virtual ICollection<Edusubstituico> Edusubstituicos { get; set; }

        public virtual ICollection<Contribuinte> Cons { get; set; }
        public virtual ICollection<Eduserie> Series { get; set; }
    }
}
