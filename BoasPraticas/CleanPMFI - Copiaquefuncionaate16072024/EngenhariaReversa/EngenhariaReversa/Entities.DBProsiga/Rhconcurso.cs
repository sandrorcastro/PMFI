using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Rhconcurso
    {
        public Rhconcurso()
        {
            RhdadosFuncionais = new HashSet<RhdadosFuncionai>();
        }

        public long ConcId { get; set; }
        public string? ConcNumero { get; set; }
        public DateTime? ConcData { get; set; }

        public virtual ICollection<RhdadosFuncionai> RhdadosFuncionais { get; set; }
    }
}
