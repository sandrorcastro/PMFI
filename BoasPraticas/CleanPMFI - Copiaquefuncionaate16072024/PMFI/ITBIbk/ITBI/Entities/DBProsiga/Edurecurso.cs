using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Edurecurso
{
    public long RecId { get; set; }

    public string? RecNome { get; set; }

    public virtual ICollection<Eduturma> Eduturmas { get; set; } = new List<Eduturma>();

    public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiRecIdatualNavigations { get; set; } = new List<RhdadosFuncionai>();

    public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiRecIdpadraoNavigations { get; set; } = new List<RhdadosFuncionai>();
}
