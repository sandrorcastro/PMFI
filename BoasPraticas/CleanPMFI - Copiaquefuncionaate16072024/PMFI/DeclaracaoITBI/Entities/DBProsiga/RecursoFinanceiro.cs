using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class RecursoFinanceiro
{
    public int RecursoId { get; set; }

    public string? RecursoNome { get; set; }

    public virtual ICollection<Acessorio> Acessorios { get; set; } = new List<Acessorio>();
}
