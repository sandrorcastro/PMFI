using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Rhconcurso
{
    public long ConcId { get; set; }

    public string? ConcNumero { get; set; }

    public DateTime? ConcData { get; set; }

    public virtual ICollection<RhdadosFuncionai> RhdadosFuncionais { get; set; } = new List<RhdadosFuncionai>();
}
