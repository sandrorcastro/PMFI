using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Edurecurso
    {
        public Edurecurso()
        {
            Eduturmas = new HashSet<Eduturma>();
            RhdadosFuncionaiRecIdatualNavigations = new HashSet<RhdadosFuncionai>();
            RhdadosFuncionaiRecIdpadraoNavigations = new HashSet<RhdadosFuncionai>();
        }

        public long RecId { get; set; }
        public string? RecNome { get; set; }

        public virtual ICollection<Eduturma> Eduturmas { get; set; }
        public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiRecIdatualNavigations { get; set; }
        public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiRecIdpadraoNavigations { get; set; }
    }
}
